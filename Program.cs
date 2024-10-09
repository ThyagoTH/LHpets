namespace Projeto_Web_Lh_Pets_Alunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto web - LH Pets versão 1");

        app.UseStaticFiles();
        


        app.Run();
    }
}
