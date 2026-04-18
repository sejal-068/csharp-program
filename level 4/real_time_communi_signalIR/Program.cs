using Microsoft.AspNetCore.SignalR;

class ChatHub : Hub
{
    public async Task SendMessage(string msg)
    {
        await Clients.All.SendAsync("ReceiveMessage", msg);
    }
}

// In Program.cs
app.MapHub<ChatHub>("/chat");