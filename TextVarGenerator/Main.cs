using System;

namespace TextVarGenerator

// Command line operation to generate a variation of errors for given text/corpus/corpora.
//
// The format of the command as follow:
// TextVarGenerator.exe -i [inFile|inFolder] -o [outFile] -m [method]
// 
// param:
// inFile input text file path
// inFolder input folder path containing all the text files
// outFile output text file path
// method method to generate the corruptions/errors to the text, by default, random substitution of words in the text
//
{
	public class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			// read the input file
			// construct a database of the input file
			// generate corruptions and write to the output

		}
	}
}
