using SmokeQuit.Services.LocDPX;
using SmokeQuit.SoapAPIServices.LocDPX.SoapServices;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSoapCore();
builder.Services.AddScoped<IChatsLocDpxSoapService, ChatsLocDpxSoapService>();
builder.Services.AddScoped<ICoachLocDpxSoapService, CoachLocDpxSoapService>();
builder.Services.AddScoped<IServiceProviders, ServiceProviders>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseSoapEndpoint<IChatsLocDpxSoapService>("/ChatsService.asmx", new SoapEncoderOptions());
app.UseSoapEndpoint<ICoachLocDpxSoapService>("/CoachService.asmx", new SoapEncoderOptions());
app.MapControllers();

app.Run();
