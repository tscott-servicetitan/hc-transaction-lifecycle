using HotChocolate.Execution;
using HotChocolate.Execution.Processing;

namespace GraphQLTransactionLifeCycle.Platform;

public class TransactionScopeHandler : ITransactionScopeHandler
{
    public ITransactionScope Create(IRequestContext context)
    {
        return new TransactionScope();
    }
}
