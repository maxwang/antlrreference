using Antlr4.Runtime;
using System;

namespace TestExpr04
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "a=1";
            var inputStream = new AntlrInputStream(input);
            ExprLexer lexer = new ExprLexer(inputStream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new ExprParser(tokens);
            var tree = parser.prog();
            Console.WriteLine(tree.ToStringTree());
            Console.ReadLine();
        }
    }
}
