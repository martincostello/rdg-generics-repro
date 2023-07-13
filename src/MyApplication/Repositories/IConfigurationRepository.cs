namespace MyApplication.Repositories;

public interface IConfigurationRepository
{
    Task EnsureRepositoryAsync(long repositoryId, CancellationToken cancellationToken);

    Task<bool> UpdateApproveAsync(InstallationId id, bool value, CancellationToken cancellationToken);

    Task<bool> UpdateApproveAsync(RepositoryId id, bool? value, CancellationToken cancellationToken);

    Task<bool> UpdateApproveCommentAsync(InstallationId id, string value, CancellationToken cancellationToken);

    Task<bool> UpdateApproveCommentAsync(RepositoryId id, string? value, CancellationToken cancellationToken);

    Task<bool> UpdateAutomergeAsync(InstallationId id, bool value, CancellationToken cancellationToken);

    Task<bool> UpdateAutomergeAsync(RepositoryId id, bool? value, CancellationToken cancellationToken);

    Task<bool> UpdateDeploymentAsync(InstallationId id, bool value, CancellationToken cancellationToken);

    Task<bool> UpdateDeploymentAsync(RepositoryId id, bool? value, CancellationToken cancellationToken);

    Task<bool> UpdateDeploymentCommentAsync(InstallationId id, string value, CancellationToken cancellationToken);

    Task<bool> UpdateDeploymentCommentAsync(RepositoryId id, string? value, CancellationToken cancellationToken);

    Task<bool> UpdateDeploymentEnvironmentsAsync(InstallationId id, IList<string> values, CancellationToken cancellationToken);

    Task<bool> UpdateDeploymentEnvironmentsAsync(RepositoryId id, IList<string>? values, CancellationToken cancellationToken);

    Task<bool> UpdateIsDisabledAsync(InstallationId id, bool value, CancellationToken cancellationToken);

    Task<bool> UpdateIsDisabledAsync(RepositoryId id, bool? value, CancellationToken cancellationToken);

    Task<bool> UpdatePullRequestMergeMethodAsync(InstallationId id, string value, CancellationToken cancellationToken);

    Task<bool> UpdatePullRequestMergeMethodAsync(RepositoryId id, string? value, CancellationToken cancellationToken);

    Task<bool> UpdateStatusChecksAsync(InstallationId id, IList<string> values, CancellationToken cancellationToken);

    Task<bool> UpdateStatusChecksAsync(RepositoryId id, IList<string>? values, CancellationToken cancellationToken);

    Task<bool> UpdateStatusCheckAttemptsAsync(InstallationId id, int value, CancellationToken cancellationToken);

    Task<bool> UpdateStatusCheckAttemptsAsync(RepositoryId id, int? value, CancellationToken cancellationToken);
}
