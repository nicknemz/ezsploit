using System;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;

namespace OxygenURewrite.Classes.FadedsTools;

public class Pipe
{
	public string Name { get; set; }

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool WaitNamedPipe(string pipe, int timeout = 10);

	public Pipe(string n)
	{
		Name = n;
	}

	public bool Exists()
	{
		return WaitNamedPipe("\\\\.\\pipe\\" + Name);
	}

	public string Read()
	{
		if (Name == null)
		{
			throw new Exception("Pipe Name was not set.");
		}
		if (!Exists())
		{
			return "";
		}
		using NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", Name, PipeDirection.InOut);
		namedPipeClientStream.Connect();
		using StreamReader streamReader = new StreamReader(namedPipeClientStream);
		return streamReader.ReadToEnd();
	}

	public bool Write(string content)
	{
		if (Name == null)
		{
			throw new Exception("Pipe Name was not set.");
		}
		if (string.IsNullOrWhiteSpace(content) || string.IsNullOrEmpty(content))
		{
			return false;
		}
		if (!Exists())
		{
			return false;
		}
		using NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", Name, PipeDirection.InOut);
		namedPipeClientStream.Connect();
		using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream))
		{
			streamWriter.Write(content);
		}
		return true;
	}
}
