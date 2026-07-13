namespace DistributedWorkflowPatterns.Domain.Entities;

public sealed class WorkflowTransition
{
    public Guid FromStepId { get; }

    public Guid ToStepId { get; }

    public WorkflowTransition(Guid fromStepId, Guid toStepId)
    {
        FromStepId = fromStepId;
        ToStepId = toStepId;
    }
}