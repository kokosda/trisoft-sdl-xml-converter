using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;

namespace TrisoftSdlXmlConverter.App
{
	public sealed class TermsReplacer
	{
		private readonly string _term;
		private readonly string _replacement;

		public TermsReplacer(string term, string replacement)
		{
			_term = term ?? throw new ArgumentNullException(nameof(term));
			_replacement = replacement;
		}
		
		public async Task Replace(Stream contentStream, Stream outputStream)
		{
			if (contentStream is null)
				throw new ArgumentNullException();
			if (!contentStream.CanRead)
				throw new InvalidOperationException($"Content stream should be readable.");
			if (outputStream == null)
				throw new ArgumentNullException(nameof(outputStream));
			if (!outputStream.CanWrite)
				throw new InvalidOperationException($"Output stream should writable.");

			using (var xmlReader = XmlReader.Create(contentStream, new XmlReaderSettings { Async = true }))
			using (var xmlWriter = XmlWriter.Create(outputStream, new XmlWriterSettings { Async = true }))
			{
				try
				{
					while (await xmlReader.ReadAsync())
					{
						switch(xmlReader.NodeType)
						{
							case XmlNodeType.Element:
								await xmlWriter.WriteStartElementAsync(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI);

								for (int i = 0; i < xmlReader.AttributeCount; i++)
								{
									while (xmlReader.MoveToNextAttribute())
									{
										if (xmlReader.LocalName == "title")
											await xmlWriter.WriteAttributeStringAsync(xmlReader.Prefix, xmlReader.LocalName, xmlReader.NamespaceURI, xmlReader.Value.Replace(_term, _replacement));
										else
											await xmlWriter.WriteAttributesAsync(xmlReader, defattr: false);
									}
								}

								if (xmlReader.IsEmptyElement)
									await xmlWriter.WriteEndElementAsync();
								break;
							case XmlNodeType.Text:
								await xmlWriter.WriteStringAsync(xmlReader.Value.Replace(_term, _replacement));
								break;
							case XmlNodeType.EndElement:
								await xmlWriter.WriteEndElementAsync();
								break;
							case XmlNodeType.Comment:
								await xmlWriter.WriteCommentAsync(xmlReader.Value);
								break;
                     case XmlNodeType.Whitespace:
	                     await xmlWriter.WriteWhitespaceAsync(xmlReader.Value);
	                     break;
							case XmlNodeType.XmlDeclaration:
							case XmlNodeType.ProcessingInstruction:
								await xmlWriter.WriteProcessingInstructionAsync(xmlReader.Name, xmlReader.Value);
								break;
						}
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
					throw;
				}
			}
		}
	}
}