using DistributedWorkflowPatterns.Application.Compensation.Abstractions;
using DistributedWorkflowPatterns.Domain.Entities;

namespace DistributedWorkflowPatterns.Application.Compensation;

public sealed class CompensationEngine : ICompensationEngine
{
    public Task ExecuteAsync(
        Workflow workflow,
        WorkflowExecution execution,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(workflow);
        ArgumentNullException.ThrowIfNull(execution);

        if (execution.State != Domain.Enumerations.WorkflowState.Failed)
        {
            throw new InvalidOperationException(
                "Compensation can only be executed for a failed workflow.");
        }

        //todo Compensation logic will be implemented in future phases.

        return Task.CompletedTask;
    }
}