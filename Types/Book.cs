namespace GraphQLTransactionLifeCycle.Types;

public record Book(string Title, Author[] Authors)
{
    public async Task<IReadOnlyList<Author>> GetAuthorsAsync(IServiceProvider services, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        Console.WriteLine($"Book.Authors.Resolved in Scope '{services.GetHashCode()}'");
        return Authors; // Usually dataLoader used here
    }
}
