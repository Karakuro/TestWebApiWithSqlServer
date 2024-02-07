using TestWebApiWithSqlServer.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlServer<TestDbContext>(
    builder.Configuration.GetConnectionString("Default")
);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/Activities", (TestDbContext ctx) => ctx.ActivityTasks.ToList());

app.MapPost("/Activities", (TestDbContext ctx, ActivityTask task) =>
{
    task.ActivityTaskId = 0;
    ctx.Add(task);
    return ctx.SaveChanges() > 0 ? Results.Created() : Results.BadRequest();
});

app.UseHttpsRedirection();

app.Run();
