using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;

namespace SocialPlatform;

public class ExampleVoiceHost
{
    // Tcp Clients
    private List<TcpClient> clients = new List<TcpClient>();
    
    // Web Clients
    private List<WebSocket> webClients = new List<WebSocket>();
    
    // Method to host a voice room
    public async void Host()
    {
        TcpListener listener = new TcpListener(25555);
        listener.Start();
        
        // Listen for new web clients
        Task.Run(async () =>
        {
            HttpListener httpListener = new HttpListener();
            httpListener.Prefixes.Add("http://localhost:25556/");
            httpListener.Start();
            while (true)
            {
                HttpListenerContext context = await httpListener.GetContextAsync();
                if (context.Request.IsWebSocketRequest)
                {
                    ConsoleWriteLine("New web client connected");
                    HttpListenerWebSocketContext webSocketContext = await context.AcceptWebSocketAsync(null);
                    webClients.Add(webSocketContext.WebSocket);
                }
            }
        });
        
        while (true)
        {
            if (listener.Pending())
            {
                Console.WriteLine("New client connected");
                TcpClient client = listener.AcceptTcpClient();
                clients.Add(client);
            }

            foreach (var client in clients)
            {
                if (client.Connected == false)
                {
                    Console.WriteLine("Client disconnected");
                    clients.Remove(client);
                    continue;
                }
                
                if (client.Available <= 0) continue;
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = stream.Read(buffer, 0, client.ReceiveBufferSize);
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine(dataReceived);
            
                // Send the data to the other clients
                foreach (TcpClient otherClient in clients)
                {
                    if (otherClient == client)
                    {
                        continue;
                    }
                    NetworkStream otherStream = otherClient.GetStream();
                    otherStream.Write(buffer, 0, bytesRead);
                }
            }

            var tempList = webClients.ToList();

            try
            {
                foreach (var client in tempList)
                {
                    if (client?.State != WebSocketState.Open)
                    {
                        webClients.Remove(client);
                        continue;
                    }


                    byte[] buffer = new byte[32 * 1024];
                    WebSocketReceiveResult result =
                        await client.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);


                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        ConsoleWriteLine("Web client disconnected");
                        await client.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
                        continue;
                    }

                    ConsoleWriteLine("Web client sent data" + result.Count);

                    // Send the data to the other web clients
                    foreach (var otherClient in webClients)
                    {
                        if (otherClient == client)
                        {
                            continue;
                        }

                        if (otherClient.State != WebSocketState.Open) continue;

                        await otherClient.SendAsync(new ArraySegment<byte>(buffer, 0, result.Count), result.MessageType,
                            result.EndOfMessage, CancellationToken.None);
                    }
                }
            } catch (Exception e)
            {
                ConsoleWriteLine(e.Message);
            }
        }
        
    }
    
    public void ConsoleWriteLine(string message)
    {
        string date = DateTime.Now.ToString("(HH:mm:ss) ");
        Console.WriteLine( date+ message);
    }
}