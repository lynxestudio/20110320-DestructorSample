using System;
using System.Threading;

Console.Clear();
Router router = new Router("Cordoba");
Router router2 = new Router("Monterrey", new
 byte[] { 10, 3, 0, 0 });
Console.WriteLine("\n");
//simulamos un proceso en ejecucción
Console.WriteLine("\tPrimer router {0}", router.Name);
Working();
Console.WriteLine("\tSegundo router {0}", router2.Name);
Working();
Console.WriteLine("\tDone!");

static void Working()
{
	Console.Write("\ttrabajando [");
	for (int i = 1; i <= 10; i++)
		{
			Console.Write("=");
			Thread.Sleep(500);
		}
	Console.Write(">]");
	Console.WriteLine("\n");
}