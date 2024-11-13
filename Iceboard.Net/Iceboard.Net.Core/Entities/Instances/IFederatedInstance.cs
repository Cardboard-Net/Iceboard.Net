namespace Iceboard.Instances;

public interface IFederatedInstance : IIceEntity
{
    /// <summary>
    ///     Represents the host of the instance
    /// </summary>
    /// <remarks>
    ///     To iceshrimp.NET this is the ID, unlike on misskey where we have
    /// a specific ID generated for each instance. At least API wise.
    /// </remarks>
    Uri Host { get; }

    /// <summary>
    ///     Allows an instance when the current instance is running in allowlist
    /// federation.
    /// </summary>
    /// <remarks>
    ///     I have no idea what happens if you use this when in denylist federation
    /// mode.
    /// </remarks>
    /// <param name="imported">An optional bool specifying whether this is imported from a list</param>
    Task AllowAsync(bool? imported);
    
    /// <summary>
    ///     Removes an instance from the allowlist when the current instance is
    /// running in allowlist federation.
    /// </summary>
    /// <remarks>
    ///     I have no idea what happens if you use this when in denylist federation
    /// mode.
    /// </remarks>
    Task DisallowAsync();

    /// <summary>
    ///     Blocks an instance when the current instance is running in denylist
    /// federation.
    /// </summary>
    /// <remarks>
    ///     I have no idea what happens if you use this when in allowlist federation
    /// mode.
    /// </remarks>
    /// <param name="imported">An optional bool specifying whether this is imported from a list</param>
    /// <param name="reason">An optional reason for why this instance is blocked</param>
    /// <returns></returns>
    Task BlockAsync(bool? imported, string? reason);
    
    /// <summary>
    ///     Removes a block on an instance when the current instance is running
    /// in denylist federation.
    /// </summary>
    /// <remarks>
    ///     I have no idea what happens if you use this when in allowlist federation
    /// mode.
    /// </remarks>
    Task UnblockAsync();
}