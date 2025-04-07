using SoapCore;
using SOAPProgettoEsame.Logica; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddScoped<ISoapService, SoapService>();

var app = builder.Build();

app.UseRouting();

//app.MapGet("/", () => "Hello World!");

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<ISoapService>("/Service3.wsdl", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});


app.Run();
