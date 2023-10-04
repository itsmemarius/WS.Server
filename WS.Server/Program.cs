using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class ClientApp
{
    static async Task Main(string[] args)
    {
        using (var client = new ClientWebSocket())
        {
            var serverUri = new Uri("ws://localhost:8080");
            await client.ConnectAsync(serverUri, CancellationToken.None);

            Console.WriteLine("Connected to the WebSocket server.");

            while (true)
            {
                Console.Write("Enter a message (or 'exit' to quit): ");
                string message = Console.ReadLine();

                if (message.ToLower() == "exit")
                    break;

                var buffer = Encoding.UTF8.GetBytes(message);
                await client.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);

                var responseBuffer = new byte[1024];
                var result = await client.ReceiveAsync(new ArraySegment<byte>(responseBuffer), CancellationToken.None);

                if (result.MessageType == WebSocketMessageType.Text)
                {
                    var response = Encoding.UTF8.GetString(responseBuffer, 0, result.Count);
                    Console.WriteLine($"Received: {response}");
                }
            }

            await client.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closed by the client", CancellationToken.None);
        }
    }
}
