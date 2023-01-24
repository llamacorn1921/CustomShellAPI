namespace CustomShell.API.Utils;

/// <summary>
///     just some console stuff
/// </summary>
public static class ConsoleLib
{
#region EraseMethods

	public static void EraseToScreenEnd()
	{
		Console.Write("\x1b[0J");
	}

	public static void EraseToLineEnd()
	{
		Console.Write("\x1b[0K");
	}

#endregion

#region CursorMethods

	/// <summary>
	///     Move the cursor down X lines.
	/// </summary>
	/// <param name="X"> Amount of lines to move. Leave blank to default for 0 </param>
	/// <param name="LineStart"> Should it be moved to the start of the line or under the cursor position </param>
	public static void MoveCursorXDown(int X = 0, bool LineStart = false)
	{
		if (LineStart)
			Console.Write($"\x1b[{X}E");
		else
			Console.Write($"\x1b[{X}B");
	}

	public static void SaveCursorPos()
	{
		Console.Write("\x1b[s");
	}

	public static void RestoreCursorPos()
	{
		Console.Write("\x1b[u");
	}

#endregion
}