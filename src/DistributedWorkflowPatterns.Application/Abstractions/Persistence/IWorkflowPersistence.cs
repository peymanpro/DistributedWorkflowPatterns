using DistributedWorkflowPatterns.Domain.Entities;

namespace DistributedWorkflowPatterns.Application.Abstractions.Persistence;

public interface IWorkflowPersistence
{
    Task SaveWorkflowAsync(
        Workflow workflow,
        CancellationToken cancellationToken = default);

    Task SaveExecutionAsync(
        WorkflowExecution execution,
        CancellationToken cancellationToken = default);

    Task<Workflow?> LoadWorkflowAsync(
        Guid workflowId,
        CancellationToken cancellationToken = default);

    Task<WorkflowExecution?> LoadExecutionAsync(
        Guid executionId,
        CancellationToken cancellationToken = default);
}