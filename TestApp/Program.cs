using System;

namespace TestApp
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Hello World!" );
			var test = new InterfaceTest.App();
			test.Run();
		}
	}
}
