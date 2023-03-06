using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using FastColoredTextBoxNS;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class EzSploit_REBORN_UserControls_u
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("EzSploit_REBORN.UserControls.u", typeof(EzSploit_REBORN_UserControls_u).Assembly);
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static ServiceColors fastColoredTextBox1_ServiceColors => (ServiceColors)ResourceManager.GetObject("fastColoredTextBox1.ServiceColors", resourceCulture);

	internal static string fastColoredTextBox1_Text => ResourceManager.GetString("fastColoredTextBox1.Text", resourceCulture);

	internal EzSploit_REBORN_UserControls_u()
	{
	}
}
