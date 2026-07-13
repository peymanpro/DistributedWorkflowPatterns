namespace DistributedWorkflowPatterns.Application.Compensation;

public class CompensationService
{
    public async Task CompensateAsync(
        IEnumerable<string> executedSteps)
    {
        Console.WriteLine("Starting compensation...");

        foreach (var step in executedSteps.Reverse())
        {
            await CompensateStepAsync(step);
        }

        Console.WriteLine("Compensation completed.");
    }


    private async Task CompensateStepAsync(string stepName)
    {
        Console.WriteLine(
            $"Compensating step: {stepName}");

        await Task.Delay(100);
    }
}