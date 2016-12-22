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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class JSONLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, INT=4, STRING=5, LEFTPAR=6, RIGHTPAR=7, LEFTSQ=8, 
		RIGHTSQ=9, SEMICOLON=10, COMMA=11, LESSERTHAN=12, GREATERTHAN=13, PLUSPLUS=14, 
		MINUSMINUS=15, WS=16, NEWLINE=17;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "INT", "STRING", "LEFTPAR", "RIGHTPAR", "LEFTSQ", 
		"RIGHTSQ", "SEMICOLON", "COMMA", "LESSERTHAN", "GREATERTHAN", "PLUSPLUS", 
		"MINUSMINUS", "WS", "NEWLINE"
	};


		public Compiler compiler = new Compiler();


	public JSONLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

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

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public override void Action(RuleContext _localctx, int ruleIndex, int actionIndex) {
		switch (ruleIndex) {
		case 16 : NEWLINE_action(_localctx, actionIndex); break;
		}
	}
	private void NEWLINE_action(RuleContext _localctx, int actionIndex) {
		switch (actionIndex) {
		case 0:  compiler.functionManager.addNewLine();  break;
		}
	}

	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2\x13");
		sb.Append("\x62\b\x1\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6");
		sb.Append("\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f");
		sb.Append("\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4\x11\t\x11\x4");
		sb.Append("\x12\t\x12\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3");
		sb.Append("\x4\x3\x4\x3\x5\x5\x5\x31\n\x5\x3\x5\x6\x5\x34\n\x5\r\x5\xE");
		sb.Append("\x5\x35\x3\x6\x6\x6\x39\n\x6\r\x6\xE\x6:\x3\a\x3\a\x3\b\x3\b");
		sb.Append("\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x3");
		sb.Append("\xE\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x11\x6\x11T\n");
		sb.Append("\x11\r\x11\xE\x11U\x3\x11\x3\x11\x3\x12\x6\x12[\n\x12\r\x12");
		sb.Append("\xE\x12\\\x3\x12\x3\x12\x3\x12\x3\x12\x2\x2\x13\x3\x3\x5\x4");
		sb.Append("\a\x5\t\x6\v\a\r\b\xF\t\x11\n\x13\v\x15\f\x17\r\x19\xE\x1B\xF");
		sb.Append("\x1D\x10\x1F\x11!\x12#\x13\x3\x2\x5\x5\x2\x43\\\x61\x61\x63");
		sb.Append("|\x5\x2\v\v\xF\xF\"\"\x3\x2\f\f\x66\x2\x3\x3\x2\x2\x2\x2\x5");
		sb.Append("\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2");
		sb.Append("\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2");
		sb.Append("\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19");
		sb.Append("\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3");
		sb.Append("\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x3%\x3\x2\x2\x2\x5");
		sb.Append(")\x3\x2\x2\x2\a-\x3\x2\x2\x2\t\x30\x3\x2\x2\x2\v\x38\x3\x2\x2");
		sb.Append("\x2\r<\x3\x2\x2\x2\xF>\x3\x2\x2\x2\x11@\x3\x2\x2\x2\x13\x42");
		sb.Append("\x3\x2\x2\x2\x15\x44\x3\x2\x2\x2\x17\x46\x3\x2\x2\x2\x19H\x3");
		sb.Append("\x2\x2\x2\x1BJ\x3\x2\x2\x2\x1DL\x3\x2\x2\x2\x1FO\x3\x2\x2\x2");
		sb.Append("!S\x3\x2\x2\x2#Z\x3\x2\x2\x2%&\ah\x2\x2&\'\aq\x2\x2\'(\at\x2");
		sb.Append("\x2(\x4\x3\x2\x2\x2)*\ak\x2\x2*+\ap\x2\x2+,\av\x2\x2,\x6\x3");
		sb.Append("\x2\x2\x2-.\a?\x2\x2.\b\x3\x2\x2\x2/\x31\a/\x2\x2\x30/\x3\x2");
		sb.Append("\x2\x2\x30\x31\x3\x2\x2\x2\x31\x33\x3\x2\x2\x2\x32\x34\x4\x32");
		sb.Append(";\x2\x33\x32\x3\x2\x2\x2\x34\x35\x3\x2\x2\x2\x35\x33\x3\x2\x2");
		sb.Append("\x2\x35\x36\x3\x2\x2\x2\x36\n\x3\x2\x2\x2\x37\x39\t\x2\x2\x2");
		sb.Append("\x38\x37\x3\x2\x2\x2\x39:\x3\x2\x2\x2:\x38\x3\x2\x2\x2:;\x3");
		sb.Append("\x2\x2\x2;\f\x3\x2\x2\x2<=\a*\x2\x2=\xE\x3\x2\x2\x2>?\a+\x2");
		sb.Append("\x2?\x10\x3\x2\x2\x2@\x41\a}\x2\x2\x41\x12\x3\x2\x2\x2\x42\x43");
		sb.Append("\a\x7F\x2\x2\x43\x14\x3\x2\x2\x2\x44\x45\a=\x2\x2\x45\x16\x3");
		sb.Append("\x2\x2\x2\x46G\a.\x2\x2G\x18\x3\x2\x2\x2HI\a>\x2\x2I\x1A\x3");
		sb.Append("\x2\x2\x2JK\a@\x2\x2K\x1C\x3\x2\x2\x2LM\a-\x2\x2MN\a-\x2\x2");
		sb.Append("N\x1E\x3\x2\x2\x2OP\a/\x2\x2PQ\a/\x2\x2Q \x3\x2\x2\x2RT\t\x3");
		sb.Append("\x2\x2SR\x3\x2\x2\x2TU\x3\x2\x2\x2US\x3\x2\x2\x2UV\x3\x2\x2");
		sb.Append("\x2VW\x3\x2\x2\x2WX\b\x11\x2\x2X\"\x3\x2\x2\x2Y[\t\x4\x2\x2");
		sb.Append("ZY\x3\x2\x2\x2[\\\x3\x2\x2\x2\\Z\x3\x2\x2\x2\\]\x3\x2\x2\x2");
		sb.Append("]^\x3\x2\x2\x2^_\b\x12\x3\x2_`\x3\x2\x2\x2`\x61\b\x12\x2\x2");
		sb.Append("\x61$\x3\x2\x2\x2\b\x2\x30\x35:U\\\x4\b\x2\x2\x3\x12\x2");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
