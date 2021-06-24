using NUnit.Framework;

namespace TrisoftSdlXmlConverter.App.Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase("001_no_namespace", "001_no_namespace_expected")]
		public void Test1(string originalFile, string expectedFile)
		{
			var file1 = FileReader.GetXml(originalFile);
			var file2 = FileReader.GetXml(expectedFile);
			Assert.Pass();
		}
	}
}