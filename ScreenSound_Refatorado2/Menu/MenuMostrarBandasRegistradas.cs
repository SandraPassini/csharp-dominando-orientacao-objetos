namespace ScreenSound_Refatorado.Menu;
internal class MenuMostrarBandasRegistradas : Menu
{
    internal void Executar(Dictionary<string, ScreenSound_Refatorado.Modelos.Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}