using SAEA.Common;
using SAEA.MVC;
using SAEA.WebRedisManager.Libs;
using SAEA.WebSocket;
using SAEA.WebSocket.Type;
using System;
using System.Threading;

namespace SAEA.WebRedisManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.Title = "WebRedisManager v5.3.2.5";

            var config = SAEAMvcApplicationConfigBuilder.Read();

            config.Port = 80;

            config.Count = 100;

            SAEAMvcApplicationConfigBuilder.Write(config);

            SAEAMvcApplication mvcApplication = new SAEAMvcApplication(config);

            mvcApplication.Start();

            WebSocketsHelper webSocketsHelper = new WebSocketsHelper();

            webSocketsHelper.Start();

            ConsoleHelper.WriteLine("WebRedisManager Already started");

            ConsoleHelper.WriteLine("Please open on Browser：http://127.0.0.1:80/");

            ConsoleHelper.WriteLine("Enter to exit service...");

            while (true)
            {
                Thread.Sleep(50);
            }
            //ConsoleHelper.ReadLine();
        }
    }
}
