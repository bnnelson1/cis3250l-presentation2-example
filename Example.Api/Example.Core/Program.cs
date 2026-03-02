using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    
    app.MapScalarApiReference(options =>
    {
        options.WithTitle("Example API Reference")
               .WithDefaultHttpClient(ScalarTarget.JavaScript, ScalarClient.Axios);
        options.Servers = []; // This is needed to ensure Scalar uses the correct connection when running in a container.
        options.DefaultOpenAllTags = false;
        options.HideModels = true;
        options.TagSorter = TagSorter.Alpha;
        options.DisableAgent();
        options.DisableTelemetry();
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();