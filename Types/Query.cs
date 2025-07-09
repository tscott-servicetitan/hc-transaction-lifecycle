namespace GraphQLTransactionLifeCycle.Types;

[QueryType]
public static class Query
{
    public static Book GetBook()
        => new("C# in depth.", [new Author("Jon Skeet")]);
}
