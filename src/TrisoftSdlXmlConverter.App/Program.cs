using System;
using System.Reflection;
using System.Threading.Tasks;

namespace TrisoftSdlXmlConverter.App
{
	internal static class Program
	{
		static async Task Main(string[] args)
		{
			var inputDirectory = $"{Assembly.GetExecutingAssembly().Location}/work";
			var outputDirectory = $"{Assembly.GetExecutingAssembly().Location}/work";
			
			Console.WriteLine($"Start working. Input dir {inputDirectory}, output dir {outputDirectory}");
			
			var termsReplacer = new TermsReplacer(term: "Trisoft", replacement: "SDL Trisoft");
			var fileTransformer = new FileTransformer(termsReplacer);
			await fileTransformer.Transform(inputDirectory, outputDirectory);
			
			Console.WriteLine($"End of program.");
		}
	}
}