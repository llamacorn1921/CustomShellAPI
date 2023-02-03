namespace CustomShell.API.Features.Parser;

public static class CommandParser
{
    /// <summary>
    ///     Parse options that the user has given
    /// </summary>
    /// <param name="arguments"> The arguments from user </param>
    /// <returns> A list of the <see cref="CommandOption"> options </see> </returns>
    public static IList<CommandOption> ParseOptions(string[] arguments)
	{
		var results = new List<CommandOption>();

		CommandOption lastOption = null;

		foreach (string argument in arguments)
		{
			// What should we do here? Go to the next one:
			if (string.IsNullOrWhiteSpace(argument)) continue;

			// We have found a Long-Name option:
			if (argument.StartsWith("--", StringComparison.Ordinal))
			{
				// The previous argument was an option, too. Let's give it back:
				if (lastOption != null) results.Add(lastOption);

				lastOption = new CommandOption
				{
					CommandType = CommandOptionType.LongName,
					Name = argument.Substring(2)
				};
			}
			// We have found a Short-Name option:
			else if (argument.StartsWith("-", StringComparison.Ordinal))
			{
				// The previous argument was an option, too. Let's give it back:
				if (lastOption != null) results.Add(lastOption);

				lastOption = new CommandOption
				{
					CommandType = CommandOptionType.ShortName,
					Name = argument.Substring(1)
				};
			}
			// We have found a symbol:
			else if (lastOption == null)
			{
				results.Add(new CommandOption
				{
					CommandType = CommandOptionType.Symbol,
					Name = argument
				});
			}
			// And finally this is a value:
			else
			{
				// Set the Value and return this option:
				lastOption.Value = argument;

				results.Add(lastOption);

				// And reset it, because we do not expect multiple parameters:
				lastOption = null;
			}
		}

		if (lastOption != null) results.Add(lastOption);

		return results;
	}
}