using DistributedWorkflowPatterns.Domain.Enumerations;

namespace DistributedWorkflowPatterns.Domain.Entities;

public sealed class WorkflowStep
{
    public Guid Id { get; }

    public string Name { get; }

    public WorkflowStepState State { get; private set; }

    public WorkflowStep(Guid id, string name)
    {
        Id = id;
        Name = name;
        State = WorkflowStepState.Pending;
    }
}