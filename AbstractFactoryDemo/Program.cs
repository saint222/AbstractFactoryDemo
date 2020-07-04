using AbstractFactoryDemo.Factory;
using System;

namespace AbstractFactoryDemo
{
    class Program
    { 
        static void Main(string[] args)
        {
            Client client;
            client = new Client(new CocaColaFactory());
            client.RunProcess();

            client = new Client(new PepsiFactory());
            client.RunProcess();
            Console.Read();
        }
    }
}
