using System.Text.Json.Serialization;
using BIAB.WebAPI;

var builder = WebApplication.CreateSlimBuilder(args);


var app = builder.Build();

app.MapControllers();
app.Run();