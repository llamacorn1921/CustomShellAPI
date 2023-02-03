using CustomShell.API.Features.Parser;

namespace CustomShell.API.Features.Extensions;

public static class CommandOptionExtensions
{
	/// <summary>
	///     Get an option from the command parse list
	/// </summary>
	/// <param name="name"> The name to search for </param>
	/// <returns> The value </returns>
	public static string GetOption(this IList<CommandOption> options, string name)
	{
		return options.ToDictionary(c => c.Name)[name].Value;
	}
}