var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Showroom> Repo =>
[
    new("toyota", "chaser", 280, 1.9),

];
app.MapGet("/", () => "Hello World!");

app.Run();

class Showroom
{
    string marka;
    string model;
    int hp;
    int released; //в миллионах
}