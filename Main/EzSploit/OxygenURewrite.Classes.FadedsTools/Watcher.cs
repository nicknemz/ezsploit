using System;
using System.Diagnostics;
using System.Timers;

namespace OxygenURewrite.Classes.FadedsTools;

public class Watcher : IDisposable
{
	public delegate void ProcessDelegate();

	private bool _disposedValue;

	private readonly Timer _watcherTimer = new Timer();

	private string _processName;

	public bool IsInitialized;

	public event ProcessDelegate OnProcessMade;

	protected virtual void Dispose(bool disposing)
	{
		if (!_disposedValue)
		{
			if (disposing)
			{
				_watcherTimer.Dispose();
			}
			_disposedValue = true;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void OnTick(object sender, ElapsedEventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName(_processName);
		if (processesByName.Length != 0)
		{
			processesByName[0].Exited += delegate
			{
				_watcherTimer.Start();
			};
			processesByName[0].EnableRaisingEvents = true;
			_watcherTimer.Stop();
			this.OnProcessMade();
		}
	}

	public void Initialize(string procName)
	{
		if (!IsInitialized)
		{
			_watcherTimer.Interval = 1000.0;
			_watcherTimer.Elapsed += OnTick;
			_processName = procName;
			IsInitialized = true;
		}
	}

	public void SwitchProcess(string name)
	{
		_processName = name;
	}

	public void Start()
	{
		if (this.OnProcessMade == null)
		{
			throw new Exception("Expected 'onProcessMade' Delegate. None was given");
		}
		if (!IsInitialized)
		{
			throw new Exception("Expected Processwatcher to be initialized");
		}
		_watcherTimer.Start();
	}

	public void Stop()
	{
		if (this.OnProcessMade == null)
		{
			throw new Exception("Expected 'onProcessMade' Delegate. None was given");
		}
		if (!IsInitialized)
		{
			throw new Exception("Expected Processwatcher to be initialized");
		}
		_watcherTimer.Stop();
	}
}
