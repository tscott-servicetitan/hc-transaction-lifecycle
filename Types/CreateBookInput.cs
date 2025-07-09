namespace GraphQLTransactionLifeCycle.Types;

public record CreateBookInput(string Name, CreateBookAuthorInput[] Authors);
public record CreateBookAuthorInput(string Name);
