using Antlr4.Runtime;
using System;

namespace ReferenceDemo042
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "a=1";
            var inputStream = new AntlrInputStream(input);
            LabeledExprLexer lexer = new LabeledExprLexer(inputStream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new LabeledExprParser(tokens);
            var tree = parser.prog();

            EvalVisitor
            Console.WriteLine(tree.ToStringTree());
            Console.ReadLine();
        }
    }
}
