using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.InterfaceTest
{
	class Package : IPackage, IConvertible
	{
		public EPackage package { get; set; }

		/// <summary>
		/// ドメインオブジェクト
		/// DBに依存するレイヤー(Infrastructureレイヤー)に定義する。
		/// DBに依存する処理を記述する
		/// </summary>
		/// <param name="value"></param>
		public Package(string value)
		{
			EPackage temp;
			if( false == Enum.TryParse( value, true, out temp ) ) return;
			this.package = temp;
		}

		public string ToDbObject()
		{
			//return this.package.Id.ToString();
			int nValue = (int)this.package;
			return nValue.ToString();
		}
	}
}
