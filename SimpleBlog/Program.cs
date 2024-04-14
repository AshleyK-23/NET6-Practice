var builder = WebApplication.CreateBuilder(args);

//MiniBlog Service
builder.Services.AddMiniBlog(Configuration.GetSection("MiniBlog"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//MiniBlog middleware
app.UseMiniBlog();

app.Run();
