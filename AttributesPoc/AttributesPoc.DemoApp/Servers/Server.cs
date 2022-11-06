using AttributesPoc.DemoApp.Attributes;

namespace AttributesPoc.DemoApp.Servers
{
    [Company("Microsoft","USA")]
    public class Server
    {
        public string ServerName { get; set; }

        public Server(string serverName)
        {
            ServerName = serverName;
        }

        public void Start()
        {
            Console.WriteLine("Server started!");
        }

        public void Stop()
        {
            Console.WriteLine("Server stopped!");
        }
    }
}
