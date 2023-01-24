using CustomShell.API.Features;

namespace CustomShell.Commands;

public class ExtendedHelpExample : ICommand, ICommandExtHelp
{
#region Command: Info

	public string Name { get; } = "Extended Help Example";
	public string Command { get; } = "ext-help";
	public string Description { get; } = "Example for extended Help";
	public Dictionary<int, ICommandArguments> Arguments { get; } = new Dictionary<int, ICommandArguments>();
	public bool IsSudo { get; } = false;
	public string Example { get; } = "exthelp";
	public bool HasCustomHelp { get; } = true;

#endregion

#region Command: Methods

	public bool Load()
	{
		return true;
	}

	public void Execute(string[] arguments)
	{
		Console.WriteLine("Hello!");
	}

	public void CustomHelp()
	{
		Console.WriteLine("This shows instead of default help");
	}

#endregion

}