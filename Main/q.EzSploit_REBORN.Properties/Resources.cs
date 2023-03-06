using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace q.EzSploit_REBORN.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
public class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("EzSploit_REBORN.Properties.Resources", typeof(Resources).Assembly);
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
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

	public static Bitmap _20_20_20 => (Bitmap)ResourceManager.GetObject("20 20 20", resourceCulture);

	public static Bitmap _40_40_40 => (Bitmap)ResourceManager.GetObject("40 40 40", resourceCulture);

	public static Bitmap anime1 => (Bitmap)ResourceManager.GetObject("anime1", resourceCulture);

	public static Bitmap anime2 => (Bitmap)ResourceManager.GetObject("anime2", resourceCulture);

	public static Bitmap anime3 => (Bitmap)ResourceManager.GetObject("anime3", resourceCulture);

	public static Bitmap anime31 => (Bitmap)ResourceManager.GetObject("anime31", resourceCulture);

	public static Bitmap hentai2 => (Bitmap)ResourceManager.GetObject("hentai2", resourceCulture);

	public static Bitmap hentai3 => (Bitmap)ResourceManager.GetObject("hentai3", resourceCulture);

	public static Bitmap splash => (Bitmap)ResourceManager.GetObject("splash", resourceCulture);

	public static Bitmap starsback => (Bitmap)ResourceManager.GetObject("starsback", resourceCulture);

	internal Resources()
	{
	}
}
