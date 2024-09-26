using LearningMS.Users.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ICounterService, CounterService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
