using DistributedWorkflowPatterns.Domain.Enumerations;

namespace DistributedWorkflowPatterns.Domain.Entities;

public sealed class WorkflowExecution
{
    public Guid Id { get; }

    public Guid WorkflowId { get; }

    public WorkflowState State { get; private set; }

    public Guid? CurrentStepId { get; private set; }

    public WorkflowExecution(Guid id, Guid workflowId)
    {
        Id = id;
        WorkflowId = workflowId;
        State = WorkflowState.Created;
    }

    public void Start(Guid firstStepId)
    {
        if (State != WorkflowState.Created)
            throw new InvalidOperationException("Workflow execution has already started.");

        CurrentStepId = firstStepId;
        State = WorkflowState.Running;
    }

    public void Complete()
    {
        if (State != WorkflowState.Running)
            throw new InvalidOperationException("Workflow is not running.");

        State = WorkflowState.Completed;
    }

    public void Fail()
    {
        if (State != WorkflowState.Running)
            throw new InvalidOperationException("Workflow is not running.");

        State = WorkflowState.Failed;
    }
}