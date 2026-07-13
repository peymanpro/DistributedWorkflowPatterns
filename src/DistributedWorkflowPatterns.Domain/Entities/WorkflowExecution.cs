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
}