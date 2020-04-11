using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.InterfaceTest
{
	public enum EPackage
	{
		TRAY = 0,
		PAPER = 4,
	}

	/// <summary>
	/// ドメインオブジェクト。ドメインレイヤーに定義する
	/// </summary>
	interface IPackage
	{
		public EPackage package { get; set; }
	}
}
