//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Hello.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class HelloParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, ID=5, NUM=6, INT_TYPE=7, COMMENT=8, WS=9;
	public const int
		RULE_prog = 0, RULE_decl = 1, RULE_expr = 2;
	public static readonly string[] ruleNames = {
		"prog", "decl", "expr"
	};

	private static readonly string[] _LiteralNames = {
		null, "':'", "'='", "'*'", "'+'", null, null, "'INT'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, "ID", "NUM", "INT_TYPE", "COMMENT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Hello.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static HelloParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public HelloParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public HelloParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ProgContext : ParserRuleContext {
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prog; } }
	 
		public ProgContext() { }
		public virtual void CopyFrom(ProgContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class ProgramContext : ProgContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(HelloParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public DeclContext[] decl() {
			return GetRuleContexts<DeclContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public DeclContext decl(int i) {
			return GetRuleContext<DeclContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ProgramContext(ProgContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterProgram(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitProgram(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IHelloVisitor<TResult> typedVisitor = visitor as IHelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgram(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		ProgContext _localctx = new ProgContext(Context, State);
		EnterRule(_localctx, 0, RULE_prog);
		int _la;
		try {
			_localctx = new ProgramContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 8;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				State = 8;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,0,Context) ) {
				case 1:
					{
					State = 6;
					decl();
					}
					break;
				case 2:
					{
					State = 7;
					expr(0);
					}
					break;
				}
				}
				State = 10;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==ID || _la==NUM );
			State = 12;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclContext : ParserRuleContext {
		public DeclContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_decl; } }
	 
		public DeclContext() { }
		public virtual void CopyFrom(DeclContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class DeclarationContext : DeclContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(HelloParser.ID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT_TYPE() { return GetToken(HelloParser.INT_TYPE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(HelloParser.NUM, 0); }
		public DeclarationContext(DeclContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitDeclaration(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IHelloVisitor<TResult> typedVisitor = visitor as IHelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDeclaration(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DeclContext decl() {
		DeclContext _localctx = new DeclContext(Context, State);
		EnterRule(_localctx, 2, RULE_decl);
		try {
			_localctx = new DeclarationContext(_localctx);
			EnterOuterAlt(_localctx, 1);
			{
			State = 14;
			Match(ID);
			State = 15;
			Match(T__0);
			State = 16;
			Match(INT_TYPE);
			State = 17;
			Match(T__1);
			State = 18;
			Match(NUM);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
	 
		public ExprContext() { }
		public virtual void CopyFrom(ExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class MultiplicationContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public MultiplicationContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterMultiplication(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitMultiplication(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IHelloVisitor<TResult> typedVisitor = visitor as IHelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMultiplication(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AdditionContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public AdditionContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterAddition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitAddition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IHelloVisitor<TResult> typedVisitor = visitor as IHelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAddition(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class VariableContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(HelloParser.ID, 0); }
		public VariableContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterVariable(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitVariable(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IHelloVisitor<TResult> typedVisitor = visitor as IHelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVariable(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NumberContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUM() { return GetToken(HelloParser.NUM, 0); }
		public NumberContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.EnterNumber(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IHelloListener typedListener = listener as IHelloListener;
			if (typedListener != null) typedListener.ExitNumber(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IHelloVisitor<TResult> typedVisitor = visitor as IHelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumber(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(Context, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 4;
		EnterRecursionRule(_localctx, 4, RULE_expr, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 23;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ID:
				{
				_localctx = new VariableContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 21;
				Match(ID);
				}
				break;
			case NUM:
				{
				_localctx = new NumberContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 22;
				Match(NUM);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 33;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 31;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
					case 1:
						{
						_localctx = new MultiplicationContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 25;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 26;
						Match(T__2);
						State = 27;
						expr(5);
						}
						break;
					case 2:
						{
						_localctx = new AdditionContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 28;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 29;
						Match(T__3);
						State = 30;
						expr(4);
						}
						break;
					}
					} 
				}
				State = 35;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 2: return expr_sempred((ExprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 4);
		case 1: return Precpred(Context, 3);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\v', '\'', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x3', '\x2', '\x3', '\x2', '\x6', 
		'\x2', '\v', '\n', '\x2', '\r', '\x2', '\xE', '\x2', '\f', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x5', '\x4', '\x1A', '\n', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', '\"', '\n', 
		'\x4', '\f', '\x4', '\xE', '\x4', '%', '\v', '\x4', '\x3', '\x4', '\x2', 
		'\x3', '\x6', '\x5', '\x2', '\x4', '\x6', '\x2', '\x2', '\x2', '(', '\x2', 
		'\n', '\x3', '\x2', '\x2', '\x2', '\x4', '\x10', '\x3', '\x2', '\x2', 
		'\x2', '\x6', '\x19', '\x3', '\x2', '\x2', '\x2', '\b', '\v', '\x5', '\x4', 
		'\x3', '\x2', '\t', '\v', '\x5', '\x6', '\x4', '\x2', '\n', '\b', '\x3', 
		'\x2', '\x2', '\x2', '\n', '\t', '\x3', '\x2', '\x2', '\x2', '\v', '\f', 
		'\x3', '\x2', '\x2', '\x2', '\f', '\n', '\x3', '\x2', '\x2', '\x2', '\f', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\r', '\xE', '\x3', '\x2', '\x2', '\x2', 
		'\xE', '\xF', '\a', '\x2', '\x2', '\x3', '\xF', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x10', '\x11', '\a', '\a', '\x2', '\x2', '\x11', '\x12', '\a', 
		'\x3', '\x2', '\x2', '\x12', '\x13', '\a', '\t', '\x2', '\x2', '\x13', 
		'\x14', '\a', '\x4', '\x2', '\x2', '\x14', '\x15', '\a', '\b', '\x2', 
		'\x2', '\x15', '\x5', '\x3', '\x2', '\x2', '\x2', '\x16', '\x17', '\b', 
		'\x4', '\x1', '\x2', '\x17', '\x1A', '\a', '\a', '\x2', '\x2', '\x18', 
		'\x1A', '\a', '\b', '\x2', '\x2', '\x19', '\x16', '\x3', '\x2', '\x2', 
		'\x2', '\x19', '\x18', '\x3', '\x2', '\x2', '\x2', '\x1A', '#', '\x3', 
		'\x2', '\x2', '\x2', '\x1B', '\x1C', '\f', '\x6', '\x2', '\x2', '\x1C', 
		'\x1D', '\a', '\x5', '\x2', '\x2', '\x1D', '\"', '\x5', '\x6', '\x4', 
		'\a', '\x1E', '\x1F', '\f', '\x5', '\x2', '\x2', '\x1F', ' ', '\a', '\x6', 
		'\x2', '\x2', ' ', '\"', '\x5', '\x6', '\x4', '\x6', '!', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '!', '\x1E', '\x3', '\x2', '\x2', '\x2', '\"', '%', 
		'\x3', '\x2', '\x2', '\x2', '#', '!', '\x3', '\x2', '\x2', '\x2', '#', 
		'$', '\x3', '\x2', '\x2', '\x2', '$', '\a', '\x3', '\x2', '\x2', '\x2', 
		'%', '#', '\x3', '\x2', '\x2', '\x2', '\a', '\n', '\f', '\x19', '!', '#',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}