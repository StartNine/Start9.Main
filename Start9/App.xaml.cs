﻿using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation;
using Start9.Api.Modules;
using Start9.Api.Objects;

namespace Start9
{
	/// <summary>
	///     Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public App()
		{
			Globals.SettingsWindow = new Windows.SettingsWindow();
			Module.Poke();
		}

		~App()
		{
			Automation.RemoveAllEventHandlers();
		}
	}

	public static class TaskbarTools
	{
		public const int SwShownormal = 1;
		public const int SwShowminimized = 2;
		public const int SwShowmaximized = 3;

		public const int GwlStyle = -16;
		public const int GwlExstyle = -20;
		public const int Taskstyle = 0x10000000 | 0x00800000;
		public const int WsExToolwindow = 0x00000080;

		public enum TaskbarGroupingMode
		{
			Combine,
			CombineWhenFull,
			NeverCombine
		}

		public enum TaskbarGroupSideTabMode
		{
			None,
			GroupTabSingle,
			GroupTabDouble,
			JumpListButton
		}

		public enum TaskbarGroupStatus
		{
			Idle,
			Running,
			LookAtMeImOrange,
			Progress,
			ProgressPaused,
			ProgressRekt,
			ProgressIdekAnymore
		}
	}
}