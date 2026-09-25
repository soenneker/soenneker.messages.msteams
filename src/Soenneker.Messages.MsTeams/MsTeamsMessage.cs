using Soenneker.Dtos.MsTeams.Card;
using Soenneker.Messages.Base;
using System.Text.Json.Serialization;

namespace Soenneker.Messages.MsTeams;

/// <summary>
/// A Service Bus Message for Microsoft Teams webhook sending
/// </summary>
public sealed class MsTeamsMessage : Message
{
    /// <summary>
    /// Gets the Microsoft Teams card associated with this instance. This property is required and must be set during
    /// object initialization.
    /// </summary>
    [JsonPropertyName("msTeamsCard")]
    public required MsTeamsCard MsTeamsCard { get; set; }

    /// <summary>
    /// Gets the name of the channel associated with this instance.
    /// </summary>
    [JsonPropertyName("channel")]
    public required string Channel { get; set; }
}