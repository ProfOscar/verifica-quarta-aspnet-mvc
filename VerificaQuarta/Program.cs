var builder = WebApplication.CreateBuilder(args);
// Aggiunge i servizi MVC (Controllers + Views)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura il routing: usa i Controller e le Views
app.UseRouting();

// File statici (immagini, css, js, ecc...)
app.UseStaticFiles();

// Imposta la route predefinita per i Controller
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
