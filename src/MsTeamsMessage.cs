using AdaptiveCards;
using Newtonsoft.Json;
using Soenneker.Dtos.AdaptiveCard.Attachments;
using Soenneker.Dtos.MsTeams.Card;
using Soenneker.Messages.Base;
using System.Text.Json.Serialization;

namespace Soenneker.Messages.MsTeams;

/// <summary>
/// A Service Bus Message for Microsoft Teams webhook sending
/// </summary>
public class MsTeamsMessage : Message
{
    [JsonProperty("msTeamsCard")]
    [JsonPropertyName("msTeamsCard")]
    public MsTeamsCard MsTeamsCard { get; set; } = null!;

    [JsonProperty("channel")]
    [JsonPropertyName("channel")]
    public string Channel { get; set; } = null!;

    public MsTeamsMessage() : base("msteams")
    {
        NewtonsoftSerialize = true;
    }

    public MsTeamsMessage(AdaptiveCard adaptiveCard, string channel) : base("msteams")
    {
        MsTeamsCard = new MsTeamsCard
        {
            Type = "message",
            Attachments =
            [
                new AdaptiveCardAttachments
                {
                    Content = adaptiveCard
                }
            ]
        };

        NewtonsoftSerialize = true;
        Channel = channel;
    }
}