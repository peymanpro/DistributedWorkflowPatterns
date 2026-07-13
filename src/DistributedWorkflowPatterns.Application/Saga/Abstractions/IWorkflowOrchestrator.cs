using DistributedWorkflowPatterns.Domain.Entities;

namespace DistributedWorkflowPatterns.Application.Saga.Abstractions;

public interface IWorkflowOrchestrator
{
    Task StartAsync(
        Workflow workflow,
        WorkflowExecution execution,
        CancellationToken cancellationToken = default);
}