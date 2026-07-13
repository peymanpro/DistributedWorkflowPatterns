namespace DistributedWorkflowPatterns.Domain.Entities;

public sealed class Workflow
{
    private readonly List<WorkflowStep> _steps = [];

    public Guid Id { get; }

    public string Name { get; }

    public IReadOnlyCollection<WorkflowStep> Steps => _steps.AsReadOnly();

    public Workflow(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public void AddStep(WorkflowStep step)
    {
        ArgumentNullException.ThrowIfNull(step);

        _steps.Add(step);
    }

    public WorkflowStep? GetFirstStep()
    {
        return _steps.FirstOrDefault();
    }
}