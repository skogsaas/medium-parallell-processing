public async Task RunAsync(CancellationToken cancellationToken)
{
    while(!cancellationToken.IsCancellationRequested)
    {
        var messages = await ReadMessagesAsync(cancellationToken);
        var result = await ProcessMessagesAsync(messages, cancellationToken);
        var success = await WriteResultAsync(result, cancellationToken);
    }
}