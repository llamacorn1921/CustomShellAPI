namespace CustomShell;

public static class Config
{
	public static readonly string ExternalDLLFolder = Path.Combine(
		Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CustomShell");

	public static readonly string AliasFile =
		$@"{Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CustomShell")}\Alias.ll";
}