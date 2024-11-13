using Newtonsoft.Json;

namespace Iceboard.Net.Rest.API.Rest;

internal class CreateAccountParam
{
    [JsonProperty("username")]
    public required string Username { get; set; }
    
    [JsonProperty("password")]
    public required string Password { get; set; }
    
    [JsonProperty("invite")]
    public string? Invite { get; set; }
}