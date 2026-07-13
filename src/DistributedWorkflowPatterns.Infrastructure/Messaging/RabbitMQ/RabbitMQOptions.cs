namespace DistributedWorkflowPatterns.Infrastructure.Messaging.RabbitMQ;

public sealed class RabbitMQOptions
{
    public const string SectionName = "RabbitMQ";

    public string HostName { get; init; } = "localhost";

    public int Port { get; init; } = 5672;

    public string UserName { get; init; } = "guest";

    public string Password { get; init; } = "guest";
}