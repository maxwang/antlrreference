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

        public override int VisitMulDiv([NotNull] LabeledExprParser.MulDivContext context)
        {
            int left = Visit(context.expr(0));
            int right = Visit(context.expr(1));
            return (context.op.Type == LabeledExprParser.MUL)
                ? left * right
                : left / right;
        }

        public override int VisitAddSub([NotNull] LabeledExprParser.AddSubContext context)
        {
            var left = Visit(context.expr(0));
            var right = Visit(context.expr(1));

            return context.op.Type == LabeledExprParser.ADD
                ? left + right
                : left - right;
        }

        public override int VisitParens([NotNull] LabeledExprParser.ParensContext context)
        {
            return Visit(context.expr());
        }

        public override int VisitClear([NotNull] LabeledExprParser.ClearContext context)
        {
            _data.Clear();
            return 0;
        }
    }
}
