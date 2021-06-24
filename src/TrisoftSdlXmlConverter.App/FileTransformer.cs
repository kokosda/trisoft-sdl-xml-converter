using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TrisoftSdlXmlConverter.App
{
	public sealed class FileTransformer
	{
		private readonly TermsReplacer _termsReplacer;

		public FileTransformer(TermsReplacer termsReplacer)
		{
			_termsReplacer = termsReplacer ?? throw new ArgumentNullException(nameof(termsReplacer));
		}

		public async Task Transform(string inputDirectory, string outputDirectory)
		{
			var filePatterns = new [] { "*.xml", "*.xsl", "*.xslt" };
			var tasks = new List<Task>();
			
			filePatterns.AsParallel()
				.SelectMany(fp => Directory.EnumerateFiles(inputDirectory, fp, SearchOption.TopDirectoryOnly))
				.ForAll(fileName =>
				{
					Console.WriteLine($"Processing {fileName}.");

					try
					{
						var bakFile = $"{fileName}.bak";
						File.Copy(fileName, bakFile, overwrite: true);
						var outputFileName = Path.Combine(outputDirectory, Path.GetFileName(fileName));
						tasks.Add(_termsReplacer.Replace(File.OpenRead(bakFile), File.Open(outputFileName, FileMode.Create)));
					}
					catch (Exception e)
					{
						Console.WriteLine(e);
					}

					Console.WriteLine($"Done {fileName}.");
				});
			
			await Task.WhenAll(tasks);
		}
	}
}