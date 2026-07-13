using DistributedWorkflowPatterns.Application.Workflows;

namespace DistributedWorkflowPatterns.Application.Services;

public class WorkflowExecutionService
{
    public async Task ExecuteAsync(DocumentApprovalWorkflow workflow)
    {
        Console.WriteLine(
            $"Starting workflow: {workflow.Name}");

        foreach (var step in workflow.Steps)
        {
            await ExecuteStepAsync(step);
        }

        Console.WriteLine(
            $"Workflow completed: {workflow.Name}");
    }


    private async Task ExecuteStepAsync(string stepName)
    {
        Console.WriteLine(
            $"Executing step: {stepName}");

        await Task.Delay(100);
    }
}