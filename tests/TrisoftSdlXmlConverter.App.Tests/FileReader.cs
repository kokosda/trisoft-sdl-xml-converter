namespace TrisoftSdlXmlConverter.App.Tests
{
	internal sealed class FileReader
	{
		public static string GetXml(string name)
		{
			var result = Resources.Resources.ResourceManager.GetString($"_{name}");
			return result;
		}
	}
}