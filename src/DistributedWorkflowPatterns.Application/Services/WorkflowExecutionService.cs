using DistributedWorkflowPatterns.Application.Compensation;
using DistributedWorkflowPatterns.Application.Workflows;

namespace DistributedWorkflowPatterns.Application.Services;

public class WorkflowExecutionService
{
    private readonly CompensationService _compensationService;


    public WorkflowExecutionService(
        CompensationService compensationService)
    {
        _compensationService = compensationService;
    }


    public async Task ExecuteAsync(
        DocumentApprovalWorkflow workflow)
    {
        var executedSteps = new List<string>();

        try
        {
            Console.WriteLine(
                $"Starting workflow: {workflow.Name}");


            foreach (var step in workflow.Steps)
            {
                await ExecuteStepAsync(step);

                executedSteps.Add(step);
            }


            Console.WriteLine(
                $"Workflow completed: {workflow.Name}");
        }
        catch(Exception)
        {
            await _compensationService
                .CompensateAsync(executedSteps);

            throw;
        }
    }


    private async Task ExecuteStepAsync(string stepName)
    {
        Console.WriteLine(
            $"Executing step: {stepName}");

        await Task.Delay(100);
    }
}