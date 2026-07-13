namespace DistributedWorkflowPatterns.Domain.Entities;

public sealed class WorkflowCompensation
{
    public Guid StepId { get; }

    public Guid CompensationStepId { get; }

    public WorkflowCompensation(Guid stepId, Guid compensationStepId)
    {
        StepId = stepId;
        CompensationStepId = compensationStepId;
    }
}