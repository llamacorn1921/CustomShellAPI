namespace CustomShell.API.Features;

public interface ICommand
{

#region Command: Info

	[Description("The Command Name")] string Name { get; }
	[Description("The Actual Command")] string Command { get; }

	[Description("The Commands Description")]
	string Description { get; }

	[Description("The Commands Arguments")]
	Dictionary<int, ICommandArguments> Arguments { get; }

	[Description("Does the command require admin password")]
	bool IsSudo { get; }

	[Description("An Example of the command being used")]
	string Example { get; }

	[Description("Does the command implement CustomHelp interface")]
	bool HasCustomHelp { get; }

#endregion

#region Command: Methods

	[Description("Executed when loaded on startup")]
	bool Load();
	[Description("The Execute method")]
	void Execute(string[] arguments);

#endregion
}