using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TrisoftSdlXmlConverter.App.Tests
{
	[TestFixture]
	[Category("Integration")]
	public class FileTransformerTests
	{
		private FileTransformer _fileTransformer;
		
		[SetUp]
		public void Setup()
		{
			var termsReplacer = new TermsReplacer("Trisoft", "SDL Trisoft");
			_fileTransformer = new FileTransformer(termsReplacer);
		}

		[Test]
		public async Task Transform_WhenOriginalFileIsTransformed_WritesExpectedFile()
		{
			// Arrange
			var inputDirectory = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}/Resources";
			var outputDirectory = inputDirectory;

			// Act
			await _fileTransformer.Transform(inputDirectory, outputDirectory);

			// Assert
			var searchPatterns = new [] { "*.xml", "*.xsl", "*.xslt" };
			var fileNames = searchPatterns.AsParallel()
				.Select(sp => Directory.EnumerateFiles(outputDirectory, sp, SearchOption.TopDirectoryOnly))
				.SelectMany(fn => fn);

			foreach (var fileName in fileNames)
			{
				var expectedContent = FileReader.GetXml($"{fileName}_expected");
				var actualContent = await File.ReadAllTextAsync(fileName);
				
				Assert.AreEqual(expectedContent, actualContent);
			}
		}
	}
}