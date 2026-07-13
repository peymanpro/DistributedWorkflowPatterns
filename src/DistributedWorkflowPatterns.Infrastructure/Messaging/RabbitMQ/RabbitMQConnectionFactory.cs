using RabbitMQ.Client;

namespace DistributedWorkflowPatterns.Infrastructure.Messaging.RabbitMQ;

public sealed class RabbitMQConnectionFactory
{
    private readonly RabbitMQOptions _options;

    public RabbitMQConnectionFactory(RabbitMQOptions options)
    {
        _options = options;
    }

    public async Task<IConnection> CreateConnectionAsync(
        CancellationToken cancellationToken = default)
    {
        var factory = new ConnectionFactory
        {
            HostName = _options.HostName,
            Port = _options.Port,
            UserName = _options.UserName,
            Password = _options.Password
        };

        return await factory.CreateConnectionAsync(cancellationToken);
    }
}