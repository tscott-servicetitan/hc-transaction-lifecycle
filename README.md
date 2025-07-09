## HotChocolate Mutation Transaction Scopes

This purpose of this project is to demonstrate the lifecycle/workflow of
the mutation Transaction scope.

### Running

Run the application and open nitro.
The run the following operation.

```graphql
mutation CreateBook {
  createBook(input: { name: "The Forest", authors: [{ name: "Barry White"}] }) {
    book {
      title
      authors {
        name
      }
    }
  }
}
```

When you've run the mutation, go back to your IDE/CLI and view the server console logs.
You should see something like the following:

```
TransactionScope.Open
Mutation.CreateBookAsync.Start in Scope '66078393'
Book.Authors.Resolved in Scope '49590872'
TransactionScope.Complete
```

From the logs above you can see:

1. Transaction is opened/started
2. The mutation method is executed in one scope
3. The resolver is executed in another scope
4. The transaction is completed/committed

### Interpretation

As you can see, we create a book and authors in the mutation method within
scope `A`. Then before the transaction is committed/completed, we try to resolve
the authors of the created book within scope `B`.

This will result in 0 authors being returned because the two scopes are in separate transactions
and scope `A`'s transaction has yet to complete.
