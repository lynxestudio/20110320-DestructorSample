using System;
using System.Threading;

namespace Samples.TestDestructors
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Router router = new Router("Cordoba");
			Router router2 = new Router("Monterrey", new
		  byte[] { 10, 3, 0, 0 });
			Console.WriteLine("\n");
			//simulamos un proceso en ejecucción
			Console.WriteLine("Primer router {0}", router.Name);
			Working();
			Console.WriteLine("Segundo router {0}", router2.Name);
			Working();
		}

		public static void Working()
		{
			Console.Write("trabajando");
			for (int i = 1; i <= 10; i++)
			{
				Console.Write(".");
				Thread.Sleep(500);
			}
			Console.WriteLine("\n");
		}
	}
}
