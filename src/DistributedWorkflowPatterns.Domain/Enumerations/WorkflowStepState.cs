namespace DistributedWorkflowPatterns.Domain.Enumerations;

public enum WorkflowStepState
{
    Pending = 0,
    Running = 1,
    Completed = 2,
    Failed = 3,
    Compensated = 4
}