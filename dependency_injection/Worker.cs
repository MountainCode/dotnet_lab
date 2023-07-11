using Microsoft.Extensions.Hosting;

public class Worker : BackgroundService
{
    private readonly IMessageWriter _messageWriter;
    public readonly IExample _example;

    public Worker(IMessageWriter messageWriter, IExample example) {
        _messageWriter = messageWriter;
        _example = example;
    }

    protected override async Task ExecuteAsync(CancellationToken token)
    {
        Console.WriteLine(_example.Message);
        while(!token.IsCancellationRequested)
        {
            _messageWriter.Write($"Worker running at: {DateTimeOffset.UtcNow}");
            await Task.Delay(1000, token);
        }
    }
}
