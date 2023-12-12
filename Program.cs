var builder = WebApplication.CreateBuilder(args);

addServices(builder);

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();


app.Run();

void addServices(WebApplicationBuilder builder)
{
    builder.Services.AddRazorPages();
  
}