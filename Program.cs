namespace Projeto_Web_Lh_Pets_versão_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapGet("/", () => "LH Pets - Protótipo 1");

            app.MapGet("/index", (HttpContext contexto)  =>
                        {
                        contexto.Response.Redirect("index.html",false);
                        }
                        ); 

            List<Clientes> lista = new List<Clientes>();

            app.MapGet("/listaclientes", (HttpContext contexto)  =>
                        {
                            Banco b1 = new Banco();
                            var pagina = b1.GetListaString();
                            contexto.Response.WriteAsync(pagina);
                        }
                        ); 

            app.Run();
        }
    }

}
