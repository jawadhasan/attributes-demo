using AttributesPoc.DemoApp.Attributes;

namespace AttributesPoc.DemoApp.Servers
{
    [Info("This is InfoText on Server")]
    [Company("Microsoft","USA")]
    public class Server
    {
        [Info("This is ServerName Property on Server")]
        public string ServerName { get; set; }

        [Info("Id is a Guid")]
        public Guid Id { get; set; }

        public string TempNotes { get; set; }

        public Server(string serverName)
        {
            ServerName = serverName;
            Id = Guid.NewGuid();
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
