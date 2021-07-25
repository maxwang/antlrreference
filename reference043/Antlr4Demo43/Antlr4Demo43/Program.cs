using Antlr4.Runtime;
using System;
using System.IO;

namespace Antlr4Demo43
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "a=1";
            if (args.Length > 0)
            {
                var inputFile = args[0];
                if (File.Exists(inputFile))
                {
                    input = File.ReadAllText(inputFile);
                }
            }

            int col = int.Parse(args[1]);

            var inputStream = new AntlrInputStream(input);
            RowsLexer lexer = new RowsLexer(inputStream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new RowsParser(tokens, col);
            parser.BuildParseTree = false;

            parser.file();
        }
    }
}
