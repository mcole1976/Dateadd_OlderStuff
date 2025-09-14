var builder = WebApplication.CreateBuilder(args);


// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("http://localhost:1234") // Replace with your MVC app's URL
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});




// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// CORS must be before UseRouting, UseAuthorization, and MapControllerRoute
app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
