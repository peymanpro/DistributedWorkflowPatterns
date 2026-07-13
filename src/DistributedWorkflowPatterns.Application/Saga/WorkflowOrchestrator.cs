using DistributedWorkflowPatterns.Application.Saga.Abstractions;
using DistributedWorkflowPatterns.Domain.Entities;

namespace DistributedWorkflowPatterns.Application.Saga;

public sealed class WorkflowOrchestrator : IWorkflowOrchestrator
{
    public Task StartAsync(
        Workflow workflow,
        WorkflowExecution execution,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(workflow);
        ArgumentNullException.ThrowIfNull(execution);

        var firstStep = workflow.GetFirstStep();

        if (firstStep is null)
            throw new InvalidOperationException("Workflow does not contain any steps.");

        execution.Start(firstStep.Id);

        firstStep.MarkRunning();

        return Task.CompletedTask;
    }
}