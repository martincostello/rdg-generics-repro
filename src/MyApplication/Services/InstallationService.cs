namespace MyApplication.Services;

public sealed partial class InstallationService
{
    public Task<bool> UserHasAccessToInstallationAsync(long installationId) => Task.FromResult(false);

    public Task<bool> UserHasAccessToRepositoryAsync(long installationId, long repositoryId) => Task.FromResult(false);
}
