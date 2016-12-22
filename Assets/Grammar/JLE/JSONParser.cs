//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from JSON.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class JSONParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, INT=4, STRING=5, LEFTPAR=6, RIGHTPAR=7, LEFTSQ=8, 
		RIGHTSQ=9, SEMICOLON=10, COMMA=11, LESSERTHAN=12, GREATERTHAN=13, PLUSPLUS=14, 
		MINUSMINUS=15, WS=16, NEWLINE=17;
	public const int
		RULE_start = 0, RULE_prog = 1, RULE_function = 2, RULE_function_use = 3, 
		RULE_function_inside_function = 4, RULE_function_declaration = 5, RULE_for_cycle_use = 6, 
		RULE_for_cycle_inside_function = 7, RULE_statement_list = 8, RULE_statement = 9;
	public static readonly string[] ruleNames = {
		"start", "prog", "function", "function_use", "function_inside_function", 
		"function_declaration", "for_cycle_use", "for_cycle_inside_function", 
		"statement_list", "statement"
	};

	private static readonly string[] _LiteralNames = {
		null, "'for'", "'int'", "'='", null, null, "'('", "')'", "'{'", "'}'", 
		"';'", "','", "'<'", "'>'", "'++'", "'--'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "INT", "STRING", "LEFTPAR", "RIGHTPAR", "LEFTSQ", 
		"RIGHTSQ", "SEMICOLON", "COMMA", "LESSERTHAN", "GREATERTHAN", "PLUSPLUS", 
		"MINUSMINUS", "WS", "NEWLINE"
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

	public override string GrammarFileName { get { return "JSON.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }


		public Compiler compiler = new Compiler();

	public JSONParser(ITokenStream input)
		: base(input)
	{
		Interpreter = new ParserATNSimulator(this,_ATN);
	}
	public partial class StartContext : ParserRuleContext {
		public ProgContext prog() {
			return GetRuleContext<ProgContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(JSONParser.Eof, 0); }
		public StartContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_start; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.EnterStart(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.ExitStart(this);
		}
	}

	[RuleVersion(0)]
	public StartContext start() {
		StartContext _localctx = new StartContext(Context, State);
		EnterRule(_localctx, 0, RULE_start);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 20; prog();
			State = 21; Match(Eof);
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

	public partial class ProgContext : ParserRuleContext {
		public FunctionContext[] function() {
			return GetRuleContexts<FunctionContext>();
		}
		public FunctionContext function(int i) {
			return GetRuleContext<FunctionContext>(i);
		}
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prog; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.EnterProg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.ExitProg(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		ProgContext _localctx = new ProgContext(Context, State);
		EnterRule(_localctx, 2, RULE_prog);
		try {
			int _alt;
			State = 31;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 24;
				ErrorHandler.Sync(this);
				_alt = 1;
				do {
					switch (_alt) {
					case 1:
						{
						{
						State = 23; function();
						}
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					State = 26;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
				} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber );
				State = 28; function();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 30; function();
				}
				break;
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

	public partial class FunctionContext : ParserRuleContext {
		public Function_useContext function_use() {
			return GetRuleContext<Function_useContext>(0);
		}
		public Function_declarationContext function_declaration() {
			return GetRuleContext<Function_declarationContext>(0);
		}
		public For_cycle_useContext for_cycle_use() {
			return GetRuleContext<For_cycle_useContext>(0);
		}
		public FunctionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_function; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.EnterFunction(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.ExitFunction(this);
		}
	}

	[RuleVersion(0)]
	public FunctionContext function() {
		FunctionContext _localctx = new FunctionContext(Context, State);
		EnterRule(_localctx, 4, RULE_function);
		try {
			State = 36;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 33; function_use();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 34; function_declaration();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 35; for_cycle_use();
				}
				break;
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

	public partial class Function_useContext : ParserRuleContext {
		public IToken identifier;
		public IToken _SEMICOLON;
		public ITerminalNode LEFTPAR() { return GetToken(JSONParser.LEFTPAR, 0); }
		public ITerminalNode RIGHTPAR() { return GetToken(JSONParser.RIGHTPAR, 0); }
		public ITerminalNode STRING() { return GetToken(JSONParser.STRING, 0); }
		public ITerminalNode SEMICOLON() { return GetToken(JSONParser.SEMICOLON, 0); }
		public Function_useContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_function_use; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.EnterFunction_use(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.ExitFunction_use(this);
		}
	}

	[RuleVersion(0)]
	public Function_useContext function_use() {
		Function_useContext _localctx = new Function_useContext(Context, State);
		EnterRule(_localctx, 6, RULE_function_use);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 38; _localctx.identifier = Match(STRING);
			State = 39; Match(LEFTPAR);
			State = 40; Match(RIGHTPAR);
			compiler.functionManager.addFunctionToMaster((_localctx.identifier!=null?_localctx.identifier.Text:null)); 
			State = 43;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
			case 1:
				{
				State = 42; _localctx._SEMICOLON = Match(SEMICOLON);
				}
				break;
			}
			 compiler.functionManager.errorManager.checkLineEnding((_localctx._SEMICOLON!=null?_localctx._SEMICOLON.Text:null), compiler.functionManager.getCurrentLine()); 
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

	public partial class Function_inside_functionContext : ParserRuleContext {
		public IToken identifier;
		public IToken _SEMICOLON;
		public ITerminalNode LEFTPAR() { return GetToken(JSONParser.LEFTPAR, 0); }
		public ITerminalNode RIGHTPAR() { return GetToken(JSONParser.RIGHTPAR, 0); }
		public ITerminalNode STRING() { return GetToken(JSONParser.STRING, 0); }
		public ITerminalNode SEMICOLON() { return GetToken(JSONParser.SEMICOLON, 0); }
		public Function_inside_functionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_function_inside_function; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.EnterFunction_inside_function(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.ExitFunction_inside_function(this);
		}
	}

	[RuleVersion(0)]
	public Function_inside_functionContext function_inside_function() {
		Function_inside_functionContext _localctx = new Function_inside_functionContext(Context, State);
		EnterRule(_localctx, 8, RULE_function_inside_function);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 47; _localctx.identifier = Match(STRING);
			State = 48; Match(LEFTPAR);
			State = 49; Match(RIGHTPAR);
			compiler.functionManager.addFunctionToCurrentFunction((_localctx.identifier!=null?_localctx.identifier.Text:null)); 
			State = 52;
			_la = TokenStream.La(1);
			if (_la==SEMICOLON) {
				{
				State = 51; _localctx._SEMICOLON = Match(SEMICOLON);
				}
			}

			 compiler.functionManager.errorManager.checkLineEnding((_localctx._SEMICOLON!=null?_localctx._SEMICOLON.Text:null), compiler.functionManager.getCurrentLine()); 
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

	public partial class Function_declarationContext : ParserRuleContext {
		public IToken function_type;
		public IToken identifier;
		public ITerminalNode LEFTPAR() { return GetToken(JSONParser.LEFTPAR, 0); }
		public ITerminalNode RIGHTPAR() { return GetToken(JSONParser.RIGHTPAR, 0); }
		public ITerminalNode LEFTSQ() { return GetToken(JSONParser.LEFTSQ, 0); }
		public ITerminalNode RIGHTSQ() { return GetToken(JSONParser.RIGHTSQ, 0); }
		public ITerminalNode[] STRING() { return GetTokens(JSONParser.STRING); }
		public ITerminalNode STRING(int i) {
			return GetToken(JSONParser.STRING, i);
		}
		public Function_inside_functionContext[] function_inside_function() {
			return GetRuleContexts<Function_inside_functionContext>();
		}
		public Function_inside_functionContext function_inside_function(int i) {
			return GetRuleContext<Function_inside_functionContext>(i);
		}
		public For_cycle_inside_functionContext[] for_cycle_inside_function() {
			return GetRuleContexts<For_cycle_inside_functionContext>();
		}
		public For_cycle_inside_functionContext for_cycle_inside_function(int i) {
			return GetRuleContext<For_cycle_inside_functionContext>(i);
		}
		public Function_declarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_function_declaration; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.EnterFunction_declaration(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.ExitFunction_declaration(this);
		}
	}

	[RuleVersion(0)]
	public Function_declarationContext function_declaration() {
		Function_declarationContext _localctx = new Function_declarationContext(Context, State);
		EnterRule(_localctx, 10, RULE_function_declaration);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 56; _localctx.function_type = Match(STRING);
			State = 57; _localctx.identifier = Match(STRING);
			compiler.functionManager.addDeclaredFunction((_localctx.identifier!=null?_localctx.identifier.Text:null)); 
			State = 59; Match(LEFTPAR);
			State = 60; Match(RIGHTPAR);
			State = 61; Match(LEFTSQ);
			State = 66;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while (_la==T__0 || _la==STRING) {
				{
				State = 64;
				switch (TokenStream.La(1)) {
				case STRING:
					{
					State = 62; function_inside_function();
					}
					break;
				case T__0:
					{
					State = 63; for_cycle_inside_function();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 68;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			State = 69; Match(RIGHTSQ);
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

	public partial class For_cycle_useContext : ParserRuleContext {
		public IToken val_dec;
		public IToken val_init;
		public IToken val_use;
		public IToken val_total;
		public IToken val_inc;
		public ITerminalNode LEFTPAR() { return GetToken(JSONParser.LEFTPAR, 0); }
		public ITerminalNode[] SEMICOLON() { return GetTokens(JSONParser.SEMICOLON); }
		public ITerminalNode SEMICOLON(int i) {
			return GetToken(JSONParser.SEMICOLON, i);
		}
		public ITerminalNode LESSERTHAN() { return GetToken(JSONParser.LESSERTHAN, 0); }
		public ITerminalNode RIGHTPAR() { return GetToken(JSONParser.RIGHTPAR, 0); }
		public ITerminalNode LEFTSQ() { return GetToken(JSONParser.LEFTSQ, 0); }
		public ITerminalNode RIGHTSQ() { return GetToken(JSONParser.RIGHTSQ, 0); }
		public ITerminalNode[] STRING() { return GetTokens(JSONParser.STRING); }
		public ITerminalNode STRING(int i) {
			return GetToken(JSONParser.STRING, i);
		}
		public ITerminalNode[] INT() { return GetTokens(JSONParser.INT); }
		public ITerminalNode INT(int i) {
			return GetToken(JSONParser.INT, i);
		}
		public ITerminalNode PLUSPLUS() { return GetToken(JSONParser.PLUSPLUS, 0); }
		public ITerminalNode MINUSMINUS() { return GetToken(JSONParser.MINUSMINUS, 0); }
		public Function_inside_functionContext[] function_inside_function() {
			return GetRuleContexts<Function_inside_functionContext>();
		}
		public Function_inside_functionContext function_inside_function(int i) {
			return GetRuleContext<Function_inside_functionContext>(i);
		}
		public For_cycle_useContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_for_cycle_use; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.EnterFor_cycle_use(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.ExitFor_cycle_use(this);
		}
	}

	[RuleVersion(0)]
	public For_cycle_useContext for_cycle_use() {
		For_cycle_useContext _localctx = new For_cycle_useContext(Context, State);
		EnterRule(_localctx, 12, RULE_for_cycle_use);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 71; Match(T__0);
			State = 72; Match(LEFTPAR);
			State = 73; Match(T__1);
			State = 74; _localctx.val_dec = Match(STRING);
			State = 75; Match(T__2);
			State = 76; _localctx.val_init = Match(INT);
			State = 77; Match(SEMICOLON);
			State = 78; _localctx.val_use = Match(STRING);
			State = 79; Match(LESSERTHAN);
			State = 80; _localctx.val_total = Match(INT);
			State = 81; Match(SEMICOLON);
			State = 82; _localctx.val_inc = Match(STRING);
			State = 83;
			_la = TokenStream.La(1);
			if ( !(_la==PLUSPLUS || _la==MINUSMINUS) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
			    Consume();
			}
			State = 84; Match(RIGHTPAR);
			 compiler.functionManager.addForCycle((_localctx.val_dec!=null?_localctx.val_dec.Text:null), (_localctx.val_init!=null?_localctx.val_init.Text:null), (_localctx.val_use!=null?_localctx.val_use.Text:null), (_localctx.val_total!=null?_localctx.val_total.Text:null), (_localctx.val_inc!=null?_localctx.val_inc.Text:null)); 
			State = 86; Match(LEFTSQ);
			State = 90;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while (_la==STRING) {
				{
				{
				State = 87; function_inside_function();
				}
				}
				State = 92;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			State = 93; Match(RIGHTSQ);
			 compiler.functionManager.addForCycleCommandsToMaster(); 
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

	public partial class For_cycle_inside_functionContext : ParserRuleContext {
		public IToken val_dec;
		public IToken val_init;
		public IToken val_use;
		public IToken val_total;
		public IToken val_inc;
		public ITerminalNode LEFTPAR() { return GetToken(JSONParser.LEFTPAR, 0); }
		public ITerminalNode[] SEMICOLON() { return GetTokens(JSONParser.SEMICOLON); }
		public ITerminalNode SEMICOLON(int i) {
			return GetToken(JSONParser.SEMICOLON, i);
		}
		public ITerminalNode LESSERTHAN() { return GetToken(JSONParser.LESSERTHAN, 0); }
		public ITerminalNode RIGHTPAR() { return GetToken(JSONParser.RIGHTPAR, 0); }
		public ITerminalNode LEFTSQ() { return GetToken(JSONParser.LEFTSQ, 0); }
		public ITerminalNode RIGHTSQ() { return GetToken(JSONParser.RIGHTSQ, 0); }
		public ITerminalNode[] STRING() { return GetTokens(JSONParser.STRING); }
		public ITerminalNode STRING(int i) {
			return GetToken(JSONParser.STRING, i);
		}
		public ITerminalNode[] INT() { return GetTokens(JSONParser.INT); }
		public ITerminalNode INT(int i) {
			return GetToken(JSONParser.INT, i);
		}
		public ITerminalNode PLUSPLUS() { return GetToken(JSONParser.PLUSPLUS, 0); }
		public ITerminalNode MINUSMINUS() { return GetToken(JSONParser.MINUSMINUS, 0); }
		public Function_inside_functionContext[] function_inside_function() {
			return GetRuleContexts<Function_inside_functionContext>();
		}
		public Function_inside_functionContext function_inside_function(int i) {
			return GetRuleContext<Function_inside_functionContext>(i);
		}
		public For_cycle_inside_functionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_for_cycle_inside_function; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.EnterFor_cycle_inside_function(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.ExitFor_cycle_inside_function(this);
		}
	}

	[RuleVersion(0)]
	public For_cycle_inside_functionContext for_cycle_inside_function() {
		For_cycle_inside_functionContext _localctx = new For_cycle_inside_functionContext(Context, State);
		EnterRule(_localctx, 14, RULE_for_cycle_inside_function);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 96; Match(T__0);
			State = 97; Match(LEFTPAR);
			State = 98; Match(T__1);
			State = 99; _localctx.val_dec = Match(STRING);
			State = 100; Match(T__2);
			State = 101; _localctx.val_init = Match(INT);
			State = 102; Match(SEMICOLON);
			State = 103; _localctx.val_use = Match(STRING);
			State = 104; Match(LESSERTHAN);
			State = 105; _localctx.val_total = Match(INT);
			State = 106; Match(SEMICOLON);
			State = 107; _localctx.val_inc = Match(STRING);
			State = 108;
			_la = TokenStream.La(1);
			if ( !(_la==PLUSPLUS || _la==MINUSMINUS) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
			    Consume();
			}
			State = 109; Match(RIGHTPAR);
			 compiler.functionManager.addForCycle((_localctx.val_dec!=null?_localctx.val_dec.Text:null), (_localctx.val_init!=null?_localctx.val_init.Text:null), (_localctx.val_use!=null?_localctx.val_use.Text:null), (_localctx.val_total!=null?_localctx.val_total.Text:null), (_localctx.val_inc!=null?_localctx.val_inc.Text:null)); 
			State = 111; Match(LEFTSQ);
			State = 115;
			ErrorHandler.Sync(this);
			_la = TokenStream.La(1);
			while (_la==STRING) {
				{
				{
				State = 112; function_inside_function();
				}
				}
				State = 117;
				ErrorHandler.Sync(this);
				_la = TokenStream.La(1);
			}
			State = 118; Match(RIGHTSQ);
			 compiler.functionManager.addForCycleCommandsToCurrentFunction(); 
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

	public partial class Statement_listContext : ParserRuleContext {
		public Statement_listContext statement_list() {
			return GetRuleContext<Statement_listContext>(0);
		}
		public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		public Statement_listContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement_list; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.EnterStatement_list(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.ExitStatement_list(this);
		}
	}

	[RuleVersion(0)]
	public Statement_listContext statement_list() {
		return statement_list(0);
	}

	private Statement_listContext statement_list(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		Statement_listContext _localctx = new Statement_listContext(Context, _parentState);
		Statement_listContext _prevctx = _localctx;
		int _startState = 16;
		EnterRecursionRule(_localctx, 16, RULE_statement_list, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			}
			Context.Stop = TokenStream.Lt(-1);
			State = 126;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,9,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.InvalidAltNumber ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new Statement_listContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_statement_list);
					State = 122;
					if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
					State = 123; statement();
					}
					} 
				}
				State = 128;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,9,Context);
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

	public partial class StatementContext : ParserRuleContext {
		public Function_useContext function_use() {
			return GetRuleContext<Function_useContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IJSONListener typedListener = listener as IJSONListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 18, RULE_statement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 129; function_use();
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

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 8: return statement_list_sempred((Statement_listContext)_localctx, predIndex);
		}
		return true;
	}
	private bool statement_list_sempred(Statement_listContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 2);
		}
		return true;
	}

	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3\x13");
		sb.Append("\x86\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6");
		sb.Append("\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x3\x2\x3\x2\x3");
		sb.Append("\x2\x3\x3\x6\x3\x1B\n\x3\r\x3\xE\x3\x1C\x3\x3\x3\x3\x3\x3\x5");
		sb.Append("\x3\"\n\x3\x3\x4\x3\x4\x3\x4\x5\x4\'\n\x4\x3\x5\x3\x5\x3\x5");
		sb.Append("\x3\x5\x3\x5\x5\x5.\n\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6");
		sb.Append("\x3\x6\x5\x6\x37\n\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3");
		sb.Append("\a\x3\a\x3\a\a\a\x43\n\a\f\a\xE\a\x46\v\a\x3\a\x3\a\x3\b\x3");
		sb.Append("\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3");
		sb.Append("\b\x3\b\x3\b\x3\b\a\b[\n\b\f\b\xE\b^\v\b\x3\b\x3\b\x3\b\x3\t");
		sb.Append("\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t");
		sb.Append("\x3\t\x3\t\x3\t\x3\t\a\tt\n\t\f\t\xE\tw\v\t\x3\t\x3\t\x3\t\x3");
		sb.Append("\n\x3\n\x3\n\a\n\x7F\n\n\f\n\xE\n\x82\v\n\x3\v\x3\v\x3\v\x2");
		sb.Append("\x3\x12\f\x2\x4\x6\b\n\f\xE\x10\x12\x14\x2\x3\x3\x2\x10\x11");
		sb.Append("\x86\x2\x16\x3\x2\x2\x2\x4!\x3\x2\x2\x2\x6&\x3\x2\x2\x2\b(\x3");
		sb.Append("\x2\x2\x2\n\x31\x3\x2\x2\x2\f:\x3\x2\x2\x2\xEI\x3\x2\x2\x2\x10");
		sb.Append("\x62\x3\x2\x2\x2\x12{\x3\x2\x2\x2\x14\x83\x3\x2\x2\x2\x16\x17");
		sb.Append("\x5\x4\x3\x2\x17\x18\a\x2\x2\x3\x18\x3\x3\x2\x2\x2\x19\x1B\x5");
		sb.Append("\x6\x4\x2\x1A\x19\x3\x2\x2\x2\x1B\x1C\x3\x2\x2\x2\x1C\x1A\x3");
		sb.Append("\x2\x2\x2\x1C\x1D\x3\x2\x2\x2\x1D\x1E\x3\x2\x2\x2\x1E\x1F\x5");
		sb.Append("\x6\x4\x2\x1F\"\x3\x2\x2\x2 \"\x5\x6\x4\x2!\x1A\x3\x2\x2\x2");
		sb.Append("! \x3\x2\x2\x2\"\x5\x3\x2\x2\x2#\'\x5\b\x5\x2$\'\x5\f\a\x2%");
		sb.Append("\'\x5\xE\b\x2&#\x3\x2\x2\x2&$\x3\x2\x2\x2&%\x3\x2\x2\x2\'\a");
		sb.Append("\x3\x2\x2\x2()\a\a\x2\x2)*\a\b\x2\x2*+\a\t\x2\x2+-\b\x5\x1\x2");
		sb.Append(",.\a\f\x2\x2-,\x3\x2\x2\x2-.\x3\x2\x2\x2./\x3\x2\x2\x2/\x30");
		sb.Append("\b\x5\x1\x2\x30\t\x3\x2\x2\x2\x31\x32\a\a\x2\x2\x32\x33\a\b");
		sb.Append("\x2\x2\x33\x34\a\t\x2\x2\x34\x36\b\x6\x1\x2\x35\x37\a\f\x2\x2");
		sb.Append("\x36\x35\x3\x2\x2\x2\x36\x37\x3\x2\x2\x2\x37\x38\x3\x2\x2\x2");
		sb.Append("\x38\x39\b\x6\x1\x2\x39\v\x3\x2\x2\x2:;\a\a\x2\x2;<\a\a\x2\x2");
		sb.Append("<=\b\a\x1\x2=>\a\b\x2\x2>?\a\t\x2\x2?\x44\a\n\x2\x2@\x43\x5");
		sb.Append("\n\x6\x2\x41\x43\x5\x10\t\x2\x42@\x3\x2\x2\x2\x42\x41\x3\x2");
		sb.Append("\x2\x2\x43\x46\x3\x2\x2\x2\x44\x42\x3\x2\x2\x2\x44\x45\x3\x2");
		sb.Append("\x2\x2\x45G\x3\x2\x2\x2\x46\x44\x3\x2\x2\x2GH\a\v\x2\x2H\r\x3");
		sb.Append("\x2\x2\x2IJ\a\x3\x2\x2JK\a\b\x2\x2KL\a\x4\x2\x2LM\a\a\x2\x2");
		sb.Append("MN\a\x5\x2\x2NO\a\x6\x2\x2OP\a\f\x2\x2PQ\a\a\x2\x2QR\a\xE\x2");
		sb.Append("\x2RS\a\x6\x2\x2ST\a\f\x2\x2TU\a\a\x2\x2UV\t\x2\x2\x2VW\a\t");
		sb.Append("\x2\x2WX\b\b\x1\x2X\\\a\n\x2\x2Y[\x5\n\x6\x2ZY\x3\x2\x2\x2[");
		sb.Append("^\x3\x2\x2\x2\\Z\x3\x2\x2\x2\\]\x3\x2\x2\x2]_\x3\x2\x2\x2^\\");
		sb.Append("\x3\x2\x2\x2_`\a\v\x2\x2`\x61\b\b\x1\x2\x61\xF\x3\x2\x2\x2\x62");
		sb.Append("\x63\a\x3\x2\x2\x63\x64\a\b\x2\x2\x64\x65\a\x4\x2\x2\x65\x66");
		sb.Append("\a\a\x2\x2\x66g\a\x5\x2\x2gh\a\x6\x2\x2hi\a\f\x2\x2ij\a\a\x2");
		sb.Append("\x2jk\a\xE\x2\x2kl\a\x6\x2\x2lm\a\f\x2\x2mn\a\a\x2\x2no\t\x2");
		sb.Append("\x2\x2op\a\t\x2\x2pq\b\t\x1\x2qu\a\n\x2\x2rt\x5\n\x6\x2sr\x3");
		sb.Append("\x2\x2\x2tw\x3\x2\x2\x2us\x3\x2\x2\x2uv\x3\x2\x2\x2vx\x3\x2");
		sb.Append("\x2\x2wu\x3\x2\x2\x2xy\a\v\x2\x2yz\b\t\x1\x2z\x11\x3\x2\x2\x2");
		sb.Append("{\x80\b\n\x1\x2|}\f\x4\x2\x2}\x7F\x5\x14\v\x2~|\x3\x2\x2\x2");
		sb.Append("\x7F\x82\x3\x2\x2\x2\x80~\x3\x2\x2\x2\x80\x81\x3\x2\x2\x2\x81");
		sb.Append("\x13\x3\x2\x2\x2\x82\x80\x3\x2\x2\x2\x83\x84\x5\b\x5\x2\x84");
		sb.Append("\x15\x3\x2\x2\x2\f\x1C!&-\x36\x42\x44\\u\x80");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
