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
				while (await xmlReader.ReadAsync())
				{
					if (xmlReader.NodeType == XmlNodeType.Element)
					{
						await UpdateAttributeInElement(xmlReader, xmlWriter);
					}

					if (xmlReader.NodeType == XmlNodeType.Text)
					{
						await UpdateTextInElement(xmlReader, xmlWriter);
					}
				}
			}
		}

		private async Task UpdateAttributeInElement(XmlReader xmlReader, XmlWriter xmlWriter)
		{
			var node = new XmlDocument().ReadNode(xmlReader);

			if (node is null)
				return;
					
			if (node.Attributes is null)
			{
				await WriteNode(xmlReader, xmlWriter);
				return;
			}

			foreach (XmlAttribute nodeAttribute in node.Attributes)
			{
				if (nodeAttribute.Name == "title")
				{
					nodeAttribute.Value = nodeAttribute.Value?.Replace(_term, _replacement);
					await WriteNode(xmlReader, xmlWriter);
					break;
				}
			}
		}
		
		private async Task UpdateTextInElement(XmlReader xmlReader, XmlWriter xmlWriter)
		{
			var node = new XmlDocument().ReadNode(xmlReader);

			if (node is null)
				return;

			node.InnerText = node.InnerText.Replace(_term, _replacement);
			await WriteNode(xmlReader, xmlWriter);
		}

		private async Task WriteNode(XmlReader xmlReader, XmlWriter xmlWriter)
		{
			await xmlWriter.WriteNodeAsync(xmlReader, defattr: false);
		}
	}
}