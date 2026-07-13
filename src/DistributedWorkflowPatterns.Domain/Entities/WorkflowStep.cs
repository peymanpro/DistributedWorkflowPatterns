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

    public void MarkRunning()
    {
        if (State != WorkflowStepState.Pending)
            throw new InvalidOperationException("Only pending steps can be started.");

        State = WorkflowStepState.Running;
    }

    public void MarkCompleted()
    {
        if (State != WorkflowStepState.Running)
            throw new InvalidOperationException("Only running steps can be completed.");

        State = WorkflowStepState.Completed;
    }

    public void MarkFailed()
    {
        if (State != WorkflowStepState.Running)
            throw new InvalidOperationException("Only running steps can fail.");

        State = WorkflowStepState.Failed;
    }
}