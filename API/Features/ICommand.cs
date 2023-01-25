namespace CustomShell.API.Features;
/// <summary>
/// The command template
/// </summary>
public interface ICommand
{

#region Command: Info
	/// <summary>
	/// The group the command is in. Basically what package it's from.
	/// Example: Built-in would be a group
	/// </summary>
	[Description("The group the command is in")] string Group { get; }

	/// <summary>
	/// The command's name.
	/// </summary>
	[Description("The Command Name")] string Name { get; }

	/// <summary>
	/// The actual command. This is what the user types to call the command
	/// </summary>
	[Description("The Actual Command")] string Command { get; }

	/// <summary>
	/// The command's description. This is what the 'help' command uses unless the command <see cref="ICommandExtHelp">
	/// </summary>
	[Description("The Commands Description")]
	string Description { get; }

	/// <summary>
	/// The command's optional/required arguments
	/// <see cref="ICommandArguments">
	/// </summary>
	[Description("The Commands Arguments")]
	Dictionary<int, ICommandArguments> Arguments { get; }

	/// <summary>
	/// Does the command require admin permissions
	/// </summary>
	[Description("Does the command require admin password")]
	bool IsSudo { get; }

	/// <summary>
	/// An example of the command. Put arguments in brackets. If it's an optional argument then put a question mark infront of it.
	/// </summary>
	/// <code>
	/// string Example { get; } = "help [?command]";
	/// </code>
	[Description("An Example of the command being used")]
	string Example { get; }
	
	/// <summary>
	/// Does the command implement <see cref="ICommandExtHelp">
	/// </summary>
	[Description("Does the command implement CustomHelp interface")]
	bool HasCustomHelp { get; }

#endregion

#region Command: Methods

	/// <summary>
	/// Executed when loaded on start-up. This is so the command can do anything needed before it's ready to be used.
	/// </summary>
	/// <returns>Returns 'true' when succesful or false when failed</returns>
	[Description("Executed when loaded on startup. If")]
	bool Load();
	/// <summary>
	/// This is executed when the command is called
	/// </summary>
	/// <param name="arguments">The user input, excludinng the actual command</param>
	[Description("The Execute method")]
	void Execute(string[] arguments);

#endregion
}