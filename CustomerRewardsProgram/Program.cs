

using CustomerRewards.Api;
using CustomerRewards.Core;
/// <summary>
/// This is application setup File.
/// This is bare bone example of the applicaiton setup.
/// This will setup the middleware to the Httpipeline.
/// Please do not Change or Edit, it can break the application
/// </summary>
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();

//Add the Swagger Middleware
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ITransactionServices, TransactionServices>();
builder.Services.AddTransient<ITransactionRepoistory, TransactionRepoistory>();

builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Map the controller for the routing
app.MapControllers();
//Global Exception Handler
app.UseMiddleware<CustomExceptionMiddleware>();
//Bootstrap and Run the application
app.Run();