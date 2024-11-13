using Newtonsoft.Json;

namespace Iceboard.Net.Rest.API.Rest;

internal class ChangePasswordParam
{
    [JsonProperty("oldPassword")]
    public required string OldPassword { get; set; }
    
    [JsonProperty("newPassword")]
    public required string NewPassword { get; set; }
}