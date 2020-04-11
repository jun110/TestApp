using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.InterfaceTest
{
	class App
	{
		public Dictionary<string, Type> map = new Dictionary<string, Type>()
		{
			{"package", typeof( Package ) }
		};

		public void Run()
		{
			string value = "paper";
			string key = "package";

			// MapからDBに依存するレイヤーのドメインオブジェクトのタイプを取得
			Type type = map[key];

			// TypeからそのTypeのインスタンスを生成
			var args = new object[] { value };
			var test = (IConvertible)Activator.CreateInstance( type, args );

			// DB内部値と表示値が異なるオブジェクトだった場合、DBの内部値へコンバート。
			// コンバート処理は、DBに依存するレイヤーのドメインオブジェクトに定義する。
			if( null != test )
			{
				var dbObject = test.ToDbObject();
			}
		}
	}
}
