//namespace JeuxVideo_API
//{
//    public class Program
//    {
//        //public static void Main(string[] args)
//        //{
//        //    var builder = WebApplication.CreateBuilder(args);

//        //    // Add services to the container.

//        //    builder.Services.AddControllers();
//        //    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//        //    builder.Services.AddEndpointsApiExplorer();
//        //    builder.Services.AddSwaggerGen();

//        //    var app = builder.Build();

//        //    // Configure the HTTP request pipeline.
//        //    if (app.Environment.IsDevelopment())
//        //    {
//        //        app.UseSwagger();
//        //        app.UseSwaggerUI();
//        //    }

//        //    app.UseHttpsRedirection();

//        //    app.UseAuthorization();


//        //    app.MapControllers();

//        //    app.Run();
//        //}

//    }
//}

using JeuxVideo_API;
using JeuxVideo_API.Models;

//Ajouter un genre
using (ExempleContext ctx = new ExempleContext())
{
    ctx.Genres.Add(new Genre
    {
        Nom = "RPG",
    });
    ctx.Genres.Add(new Genre
    {
        Nom = "Action",
    });
    ctx.SaveChanges();
}

//Ajouter un jeu
using (ExempleContext ctx = new ExempleContext())
{
    ctx.Jeux.Add(new Jeu
    {
        Titre = "The Elder Scrolls V : Skyrim",
        AnneeSortie = 2011,
        Note = 5,
        Descriptif = "The Elder Scrolls V: Skyrim est le cinquième chapitre de la saga culte Elder Scrolls.",
        GenreId = 1
    });
    ctx.SaveChanges();
}