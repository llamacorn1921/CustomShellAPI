using CustomShell.API.Features;
using CustomShell.Handlers;

namespace CustomShell.Commands;
/// <summary>
/// Name: Change Directory
/// Command: cd [? | path | -]
/// Description: Changes the current working directory
/// </summary>
public class ChangeDirectory : ICommand
{
#region Command: Info

	public string Group { get; } = "built-in";
	public string Name { get; } = "Change Directory";
	public string Command { get; } = "cd";
	public string Description { get; } = "Changes the current working directory";

	public Dictionary<int, ICommandArguments> Arguments { get; } = new Dictionary<int, ICommandArguments>()
	{
		{
			1,
			new ICommandArguments("Path", "The path to go to", false)
		}
	};

	public bool IsSudo { get; } = false;
	public string Example { get; } = "cd [? | path | -]";
	public bool HasCustomHelp { get; } = false;

#endregion

#region Command: Methods

	public bool Load()
	{
		return true;
	}

	public void Execute(string[] arguments)
	{

		if (arguments.Length == 0)
		{
			Shell.ChangeDirectory(Shell.DefaultDirectory);
		}
		else
		{
			if (arguments.First() == "-")
				Shell.ChangeDirectory(Shell.PreviousDirectory);
			if (arguments.Length == 1)
				Shell.ChangeDirectory(arguments.First());
		}
	}

#endregion

}