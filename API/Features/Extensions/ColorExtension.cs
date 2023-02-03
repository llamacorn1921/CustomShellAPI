using CustomShell.API.Enums;

namespace CustomShell.API.Extensions;

public static class ColorExtension
{
	private static readonly string ESC = "\x1b";
	private static readonly string CSE = $"{ESC}[";

	/// <summary>
	///     MAKE IT HAS COLOR!
	/// </summary>
	/// <param name="text"> The text to extend off of </param>
	/// <param name="color"> The <see cref="ColorCodes"> Color </see> to use </param>
	/// <returns> COLOR! </returns>
	public static string Color(this string text, ColorCodes color)
	{
		int c = (int) color;
		StringBuilder str = new StringBuilder();
		str.Append($"{CSE}38;5;{c}m");
		str.Append(text);
		str.Append($"{CSE}0m");
		return str.ToString();
	}
}