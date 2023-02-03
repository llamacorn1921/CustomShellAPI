using CustomShell.API.Features;

namespace CustomShell.Commands;

/// <summary>
///     Name: Extended Help Example
///     Command: ext-help
///     Description: This command is an example of how <see cref="ICommandExtHelp"> works
/// </summary>
public class ExtendedHelpExample : ICommandExtHelp
{
#region Command: Info

	public string Group { get; } = "built-in";
	public string Name { get; } = "Extended Help Example";
	public string Command { get; } = "ext-help";
	public string Description { get; } = "Example for extended Help";
	public List<ICommandArguments> Arguments { get; } = new();
	public bool IsSudo { get; } = false;
	public string Example { get; } = "ext-help";
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