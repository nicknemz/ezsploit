using System.Diagnostics;
using System.Threading.Tasks;

namespace Comet_3.Classes.DLL;

internal class DLLInterfacing
{
	private async void Inject_Comet()
	{
	}

	public async void Execute(string script)
	{
        RuyiAPI.run_script(script);
    }
}
