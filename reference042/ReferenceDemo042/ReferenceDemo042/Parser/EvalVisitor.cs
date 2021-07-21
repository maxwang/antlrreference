using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceDemo042.Parser
{
    public class EvalVisitor : LabeledExprBaseVisitor<int>
    {
        Dictionary<string, int> _data = new Dictionary<string, int>();
        public override int VisitAssign([NotNull] LabeledExprParser.AssignContext context)
        {
            var id = context.ID().GetText();
            var value = Visit(context.expr());
            _data.Add(id, value);
            return value;
        }

        public override int VisitPrintExpr([NotNull] LabeledExprParser.PrintExprContext context)
        {
            int value = Visit(context.expr());
            Console.WriteLine(value);
            return 0;
        }

        public override int VisitINT([NotNull] LabeledExprParser.INTContext context)
        {
            return int.Parse(context.INT().GetText());
        }

        public override int VisitId([NotNull] LabeledExprParser.IdContext context)
        {
            var id = context.ID().GetText();
            return _data.ContainsKey(id)
                ? _data[id]
                : 0;
        }
    }
}
