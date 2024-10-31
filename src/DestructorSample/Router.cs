using System;


public class Router
{
	public string Name { private set; get; }
	public byte[] IPNetwork { private set; get; }
	public Router(string name)
	{
		Name = name;
		Console.WriteLine("{0} Creado {1}", Name, DateTime.Now);
	}
	public Router(string name, byte[] ipnet)
	{
		Name = name;
		IPNetwork = ipnet;
		Console.WriteLine("{0} Creado {1}", Name, DateTime.Now);
	}

	~Router()
	{
		Console.WriteLine("{0} Destruido {1}", Name, DateTime.Now);
	}
}