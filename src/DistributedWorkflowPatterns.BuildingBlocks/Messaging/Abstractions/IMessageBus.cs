namespace DistributedWorkflowPatterns.BuildingBlocks.Messaging.Abstractions;

public interface IMessageBus :
    IMessagePublisher,
    IMessageSubscriber
{
}