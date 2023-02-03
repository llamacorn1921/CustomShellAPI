using CustomShell.API.Features.Parser;

namespace CustomShell.API.Features;

/// <summary>
///     Builder for the commands arguments
/// </summary>
public class ICommandArguments
{
	/// <summary>
	///     Command Argument builder
	/// </summary>
	/// <param name="name"> The name of the argument </param>
	/// <param name="optionType"> The <see cref="CommandOptionType"> type </see> of the argument </param>
	/// <param name="description"> Argument description </param>
	/// <param name="isRequired"> Is the argument required </param>
	public ICommandArguments(string name, CommandOptionType optionType, string description, bool isRequired)
	{
		Name = name;
		OptionType = optionType;
		Description = description;
		IsRequired = isRequired;
	}

	/// <summary>
	///     Argument name
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	///     Argument type
	/// </summary>
	/// <see cref="CommandOptionType" />
	public CommandOptionType OptionType { get; set; }

	/// <summary>
	///     Is the argument required
	/// </summary>
	public bool IsRequired { get; set; }

	/// <summary>
	///     Argument description
	/// </summary>
	public string Description { get; set; }
}