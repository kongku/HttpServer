using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTTPServerLib;
using HttpServer;

namespace HTTPServerLib
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleServer server = new ExampleServer("192.168.132.208", 8321);
            server.SetRoot(@"F:\WebServer\public");
            server.Logger = new ConsoleLogger();
            server.Start();
        }
    }
}
