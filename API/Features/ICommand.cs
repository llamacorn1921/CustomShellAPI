namespace CustomShell.API.Features;

/// <summary>
///     The command template
/// </summary>
public interface ICommand
{
#region Command: Info

	/// <summary>
	///     The group the command is in. Basically what package it's from.
	///     Example: Built-in would be a group
	/// </summary>
	string Group { get; }

	/// <summary>
	///     The command's name.
	/// </summary>
	string Name { get; }

	/// <summary>
	///     The actual command. This is what the user types to call the command
	/// </summary>
	string Command { get; }

	/// <summary>
	///     The command's description. This is what the 'help' command uses unless the command implements
	///     <see cref="ICommandExtHelp"> a custom help message </see>
	/// </summary>
	string Description { get; }

	/// <summary>
	///     The command's optional/required arguments
	///     <see cref="ICommandArguments" />
	/// </summary>
	List<ICommandArguments> Arguments { get; }

	/// <summary>
	///     Does the command require admin permissions
	/// </summary>
	bool IsSudo { get; }

	/// <summary>
	///     An example of the command. Put arguments in brackets. If it's an optional argument then put a question mark infront
	///     of it.
	/// </summary>
	/// <code>
	/// string Example { get; } = "help [?command]";
	/// </code>
	string Example { get; }

	/// <summary>
	///     Does the command implement <see cref="ICommandExtHelp">
	/// </summary>
	bool HasCustomHelp { get; }

#endregion

#region Command: Methods

	/// <summary>
	///     Executed when loaded on start-up. This is so the command can do anything needed before it's ready to be used.
	/// </summary>
	/// <returns> Returns 'true' when successful or false when failed </returns>
	bool Load();

	/// <summary>
	///     This is executed when the command is called
	/// </summary>
	/// <param name="arguments"> The user input, excluding the actual command </param>
	void Execute(string[] arguments);

#endregion
}