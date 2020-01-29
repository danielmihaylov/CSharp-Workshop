using System;
using System.Threading.Tasks;

namespace DemoApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpServer = new SIS.Http.HttpServer(80);
            await httpServer.StartAsync();
        }
    }
}
