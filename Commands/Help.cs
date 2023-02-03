using CustomShell.API.Features;
using CustomShell.API.Features.Parser;
using CustomShell.Handlers;

namespace CustomShell.Commands;

/// <summary>
///     Name: Help
///     Command: help [?command]
///     Description: This command get's information about each command for it's usage.
/// </summary>
public class Help : ICommand
{
	private void _getCommandHelp(ICommand command)
	{
		// displays default info
		// Name: command name
		// Example: command example
		// Description: command desc
		// Arguments
		// etc
	}

#region Command: Info

	public string Group { get; } = "built-in";
	public string Name { get; } = "Help";
	public string Command { get; } = "help";

	public string Description { get; } =
		"The Help command. This command is used to give insight on each existing command.";

	public List<ICommandArguments> Arguments { get; } = new()
	{
		new("Command", CommandOptionType.Symbol, "The command to get help for", false)
	};

	public bool IsSudo { get; } = false;
	public string Example { get; } = "help [?command]";
	public bool HasCustomHelp { get; } = false;

#endregion

#region Command: Methods

	public bool Load()
	{
		return true;
	}

	public void Execute(string[] arguments)
	{
		if (arguments.Length > 0 && Shell.Commands.ContainsKey(arguments.First()))
		{
			ICommand command = Shell.Commands[arguments.First()];
			if (command.HasCustomHelp)
				Shell.CommandsHelpExt[command.Command].CustomHelp();
			else
				_getCommandHelp(command);
		}
		else
		{
			AnsiConsole.MarkupLineInterpolated(
				$"[green]Total Amount of Commands[/][bold white]:[/] [aqua]{Shell.TotalCommands.ToString()}[/]");
			foreach (var command in Shell.Commands)
				AnsiConsole.MarkupLineInterpolated(
					$"[lime]Command[/][bold white]:[/] [aqua]{command.Value.Example}[/]");
		}
	}

#endregion
}