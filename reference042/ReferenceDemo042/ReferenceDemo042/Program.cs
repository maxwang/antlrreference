using Antlr4.Runtime;
using ReferenceDemo042.Parser;
using System;
using System.IO;

namespace ReferenceDemo042
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "a=1";
            if (args.Length > 0)
            {
                var inputFile = args[0];
                if(File.Exists(inputFile))
                {
                    input = File.ReadAllText(inputFile);
                }
            }
            
            var inputStream = new AntlrInputStream(input);
            LabeledExprLexer lexer = new LabeledExprLexer(inputStream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new LabeledExprParser(tokens);
            var tree = parser.prog();

            EvalVisitor eval = new EvalVisitor();
            eval.Visit(tree);
            
            Console.ReadLine();
        }
    }
}
