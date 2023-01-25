using CustomShell.API.Features;

namespace CustomShell.Commands;
/// <summary>
/// Name: Clear
/// Command: cls
/// Description: Will clear the screen.
/// </summary>
public class Clear : ICommand
{
#region Command: Info

	public string Group { get; } = "built-in";
	public string Name { get; } = "Clear";
	public string Command { get; } = "cls";
	public string Description { get; } = "Clears the console";
	public Dictionary<int, ICommandArguments> Arguments { get; } = new Dictionary<int, ICommandArguments>();
	public bool IsSudo { get; } = false;
	public string Example { get; } = "cls";
	public bool HasCustomHelp { get; } = false;

#endregion

#region Command: Methods

	public bool Load()
	{
		return true;
	}

	public void Execute(string[] arguments)
	{
		Console.Clear();
	}

#endregion

}