using ScreenSound_Refatorado.Modelos;

namespace ScreenSound_Refatorado.Menu;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
