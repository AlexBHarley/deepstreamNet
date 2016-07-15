using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeepStreamNet;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();

            p.Run();

            Console.ReadLine();
            
        }

        public async void Run()
        {
            var client = new DeepStreamClient("localhost", 6021);
            var client2 = new DeepStreamClient("localhost", 6021);

            await client.LoginAsync();
            await client2.LoginAsync();

            var eventSubscription = await client.Events.Subscribe("test", x => 
            {
                Console.WriteLine("From 1: " + x);
            });

            // Send 'Hello' to all Subscribers of Event 'test'
            await client2.Events.PublishAsync("test", "Hello");
        }


    }
}
