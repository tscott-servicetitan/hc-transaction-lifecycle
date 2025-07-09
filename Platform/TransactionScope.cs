using HotChocolate.Execution.Processing;

namespace GraphQLTransactionLifeCycle.Platform;

public class TransactionScope : ITransactionScope
{
    public TransactionScope()
    {
        Console.WriteLine("TransactionScope.Open");
    }

    public void Complete()
    {
        Console.WriteLine("TransactionScope.Complete");
    }

    public void Dispose()
    {
    }
}
