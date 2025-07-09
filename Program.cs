using GraphQLTransactionLifeCycle.Platform;

var builder = WebApplication.CreateBuilder(args);

builder
    .AddGraphQL()
    .AddTypes()
    .AddTransactionScopeHandler<TransactionScopeHandler>();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
