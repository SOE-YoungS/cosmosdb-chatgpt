using Newtonsoft.Json;
using System.Security.Principal;

namespace Cosmos.Chat.GPT.Models;

public record Session
{
    /// <summary>
    /// Unique identifier
    /// </summary>
    public string Id { get; set; }

    public string Type { get; set; }

    /// <summary>
    /// Partition key
    /// </summary>
    public string SessionId { get; set; }

    public string ModelId { get; set; }

    public string UserId { get; set; }

    public int? TokensUsed { get; set; }

    public string Name { get; set; }

    [JsonIgnore]
    public List<Message> Messages { get; set; }

    public Session()
    {
        Id = Guid.NewGuid().ToString();
        Type = nameof(Session);
        SessionId = this.Id;
        UserId = string.Empty;
        TokensUsed = 0;
        Name = "New Chat";
        Messages = new List<Message>();
        ModelId = nameof(Session.ModelId);
    }

    public void AddMessage(Message message)
    {
        Messages.Add(message);
    }

    public void UpdateMessage(Message message)
    {
        var match = Messages.Single(m => m.Id == message.Id);
        var index = Messages.IndexOf(match);
        Messages[index] = message;
    }
}