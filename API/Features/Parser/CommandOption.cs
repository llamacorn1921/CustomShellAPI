namespace CustomShell.API.Features.Parser;

/// <summary>
///     The command options
/// </summary>
public class CommandOption
{
	/// <summary>
	///     The option name
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	///     The option value
	/// </summary>
	public string Value { get; set; }

	/// <summary>
	///     The option type
	/// </summary>
	public CommandOptionType CommandType { get; set; }
}