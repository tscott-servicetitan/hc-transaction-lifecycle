namespace GraphQLTransactionLifeCycle.Types;

[MutationType]
public static class Mutation
{
    public static async Task<CreateBookPayload> CreateBookAsync(
        [Service] IServiceProvider services,
        CreateBookInput input,
        CancellationToken cancellationToken)
    {
        Console.WriteLine($"Mutation.CreateBookAsync.Start in Scope '{services.GetHashCode()}'");

        var authors = input.Authors.Select(author => new Author(author.Name)).ToArray();
        var book = new Book(input.Name, authors);

        return new CreateBookPayload { Book = book };
    }
}
