namespace DistributedWorkflowPatterns.Domain.Enumerations;

public enum WorkflowState
{
    Created = 0,
    Running = 1,
    Completed = 2,
    Failed = 3,
    Compensating = 4,
    Compensated = 5
}