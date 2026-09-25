using System.Text.Json.Serialization;
using Soenneker.Dtos.MsTeams.Card;

namespace Soenneker.Messages.MsTeams;

/// <summary>Provides generated JSON metadata for Teams webhook payloads and Service Bus envelopes.</summary>
[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(MsTeamsCard))]
[JsonSerializable(typeof(MsTeamsMessage))]
public partial class MsTeamsJsonContext : JsonSerializerContext
{
}
