namespace DistributedWorkflowPatterns.BuildingBlocks.Messaging.Models;

public abstract class Message
{
    protected Message()
    {
        Id = Guid.NewGuid();
        CorrelationId = Guid.NewGuid();
        CreatedAtUtc = DateTime.UtcNow;
    }

    public Guid Id { get; }

    public Guid CorrelationId { get; init; }

    public DateTime CreatedAtUtc { get; }
}