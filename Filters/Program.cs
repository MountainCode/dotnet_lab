var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(os => os.Filters.Add<SampleActionFilter>());
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
