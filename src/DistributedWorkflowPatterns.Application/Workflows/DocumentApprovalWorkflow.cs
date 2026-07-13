namespace DistributedWorkflowPatterns.Application.Workflows;

public class DocumentApprovalWorkflow
{
    public string Name => "DocumentApprovalWorkflow";

    public IReadOnlyList<string> Steps =>
    [
        "ValidateDocument",
        "ApproveDocument"
    ];
}