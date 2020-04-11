using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.InterfaceTest
{
	/// <summary>
	/// ドメインオブジェクトの値とDBに保存する値とで違いがある場合に付与するインターフェース。
	/// 変更するオブジェクトだからConvertibleっていう名前にしてるけど、意味があってるかわからん
	/// </summary>
	interface IConvertible
	{
		string ToDbObject();
	}
}
