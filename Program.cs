var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseFileServer();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

// Optionally, configure fallback to index.html for SPA routing
app.MapFallbackToFile("index.html");

app.Run();