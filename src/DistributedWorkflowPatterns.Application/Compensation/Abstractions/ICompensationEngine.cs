using DistributedWorkflowPatterns.Domain.Entities;

namespace DistributedWorkflowPatterns.Application.Compensation.Abstractions;

public interface ICompensationEngine
{
    Task ExecuteAsync(
        Workflow workflow,
        WorkflowExecution execution,
        CancellationToken cancellationToken = default);
}