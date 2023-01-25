using CustomShell.API.Features;

namespace CustomShell.API.Log;
public static class LogCommand
{
    /// <summary>
    /// Command Logger. Log some info.
    /// </summary>
    /// <param name="command">The command being used or command to log.</param>
    /// <param name="message">The message to log</param>
    public static void Info(ICommand command, string message)
    {
        AnsiConsole.MarkupLineInterpolated($"[bold lime][[COMMAND LOG: INFO]][/] [white]{message}[/]");
        AnsiConsole.MarkupLineInterpolated($"[aqua]Command:[/] [white]{command.Command}[/]");
    }
    /// <summary>
    /// Command Logger. Log some info.
    /// </summary>
    /// <param name="command">The command being used or command to log.</param>
    /// <param name="message">The message to log</param>
    public static void Info(ICommand command, object message)
    {
        AnsiConsole.MarkupLineInterpolated($"[bold lime][[COMMAND LOG: INFO]][/] [white]{message}[/]");
        AnsiConsole.MarkupLineInterpolated($"[aqua]Command:[/] [white]{command.Command}[/]");
    }

    /// <summary>
    /// Command Logger. Log a warning.
    /// </summary>
    /// <param name="command">The command being used or command to log.</param>
    /// <param name="message">The message to log</param>
    public static void Warn(ICommand command, string message)
    {
        AnsiConsole.MarkupLineInterpolated($"[bold yellow][[COMMAND LOG: WARN]][/] [white]{message}[/]");
        AnsiConsole.MarkupLineInterpolated($"[aqua]Command:[/] [white]{command.Command}[/]");
    }
    /// <summary>
    /// Command Logger. Log a warning.
    /// </summary>
    /// <param name="command">The command being used or command to log.</param>
    /// <param name="message">The message to log</param>
    public static void Warn(ICommand command, object message)
    {
        AnsiConsole.MarkupLineInterpolated($"[bold yellow][[COMMAND LOG: warn]][/] [white]{message}[/]");
        AnsiConsole.MarkupLineInterpolated($"[aqua]Command:[/] [white]{command.Command}[/]");
    }

    /// <summary>
    /// Command Logger. Log some debug.
    /// </summary>
    /// <param name="command">The command being used or command to log.</param>
    /// <param name="message">The message to log</param>
    public static void Debug(ICommand command, string message)
    {
        AnsiConsole.MarkupLineInterpolated($"[bold orange1][[COMMAND LOG: DEBUG]][/] [white]{message}[/]");
        AnsiConsole.MarkupLineInterpolated($"[aqua]Command:[/] [white]{command.Command}[/]");
    }
    /// <summary>
    /// Command Logger. Log some debug.
    /// </summary>
    /// <param name="command">The command being used or command to log.</param>
    /// <param name="message">The message to log</param>
    public static void Debug(ICommand command, object message)
    {
        AnsiConsole.MarkupLineInterpolated($"[bold orange1][[COMMAND LOG: DEBUG]][/] [white]{message}[/]");
        AnsiConsole.MarkupLineInterpolated($"[aqua]Command:[/] [white]{command.Command}[/]");
    }

    /// <summary>
    /// Command Logger. Log an error.
    /// </summary>
    /// <param name="command">The command being used or command to log.</param>
    /// <param name="message">The message to log</param>
    public static void Error(ICommand command, string message)
    {
        AnsiConsole.MarkupLineInterpolated($"[bold red1][[COMMAND LOG: ERROR]][/] [white]{message}[/]");
        AnsiConsole.MarkupLineInterpolated($"[aqua]Command:[/] [white]{command.Command}[/]");
    }
    /// <summary>
    /// Command Logger. Log an error.
    /// </summary>
    /// <param name="command">The command being used or command to log.</param>
    /// <param name="message">The message to log</param>
    public static void Error(ICommand command, object message)
    {
        AnsiConsole.MarkupLineInterpolated($"[bold red1][[COMMAND LOG: ERROR]][/] [white]{message}[/]");
        AnsiConsole.MarkupLineInterpolated($"[aqua]Command:[/] [white]{command.Command}[/]");
    }

}