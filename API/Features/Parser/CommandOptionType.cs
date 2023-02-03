namespace CustomShell.API.Features.Parser;

public enum CommandOptionType
{
	/// <summary>
	///     Long name
	/// </summary>
	[Description("--option")] LongName,

	/// <summary>
	///     Short name
	/// </summary>
	[Description("-o")] ShortName,

	/// <summary>
	///     Symbol
	/// </summary>
	[Description("Neither")] Symbol
}