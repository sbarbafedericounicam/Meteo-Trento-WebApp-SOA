using SoapCore;
using ServiziMeteo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddScoped<ISoapService, SoapService>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<ISoapService>("/ServizioSoapMeteo.wsdl", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});

app.Run();

