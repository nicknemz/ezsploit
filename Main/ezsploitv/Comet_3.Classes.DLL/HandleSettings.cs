using Microsoft.Win32;

namespace Comet_3.Classes;

internal class HandleSettings
{
	private RegistryKey RegistrySettings = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Supercomet3");

	public void SetSettings(string name, string value)
	{
		RegistrySettings.SetValue(name, value);
	}

	public string ReadSettings(string name)
	{
		return (string)RegistrySettings.GetValue(name);
	}

	public void StartupSettingsSystem()
	{
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "SetupCompletion", null) == null)
		{
			SetSettings("SetupCompletion", "false");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "ProfilePicture", null) == null)
		{
			SetSettings("ProfilePicture", "");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "CGPTKey", null) == null)
		{
			SetSettings("CGPTKey", "");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "ProfileName", null) == null)
		{
			SetSettings("ProfileName", "CometUser");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "topmost", null) == null)
		{
			SetSettings("topmost", "true");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "PatchCheck", null) == null)
		{
			SetSettings("PatchCheck", "false");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "BetaCheck", null) == null)
		{
			SetSettings("BetaCheck", "false");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "TabCheck", null) == null)
		{
			SetSettings("TabCheck", "true");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "AutoAttachCheck", null) == null)
		{
			SetSettings("AutoAttachCheck", "false");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "InjectCheck", null) == null)
		{
			SetSettings("InjectCheck", "true");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "InjectCheckOption", null) == null)
		{
			SetSettings("InjectCheckOption", "GSGB");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "UseMonaco", null) == null)
		{
			SetSettings("UseMonaco", "false");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "GIFShadow", null) == null)
		{
			SetSettings("GIFShadow", "false");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "ReallySureUseMonaco", null) == null)
		{
			SetSettings("ReallySureUseMonaco", "true");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "DiscordRPC", null) == null)
		{
			SetSettings("DiscordRPC", "false");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "ForceCheckKey", null) == null)
		{
			SetSettings("ForceCheckKey", "false");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "Distributor", null) == null)
		{
			SetSettings("Distributor", "wearedevs.net");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "FPSCap", null) == null)
		{
			SetSettings("FPSCap", "60");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "CometTransparencyValue", null) == null)
		{
			SetSettings("CometTransparencyValue", "1");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "Experimental268PreventCheck", null) == null)
		{
			SetSettings("Experimental268PreventCheck", "false");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "IsPatched", null) == null)
		{
			SetSettings("IsPatched", "false");
		}
		if (Registry.GetValue("HKEY_CURRENT_USER\\Software\\Supercomet3", "AlphaMessageRead", null) == null)
		{
			SetSettings("AlphaMessageRead", "false");
		}
	}
}
