namespace CustomShell.API.Features;

/// <summary>
///     Just some extra utils to help out
/// </summary>
public static class CommandUtils
{
	/// <summary>
	/// Gets the amount of required arguments given the arguments dictionary
	/// </summary>
	/// <param name="commandArguments">The commands arguments</param>
	/// <returns>Count of required arguments</returns>
	public static int GetRequiredArgsInt(Dictionary<int, ICommandArguments> commandArguments)
	{
		return commandArguments.Count(x => x.Value.IsRequired);
	}
}