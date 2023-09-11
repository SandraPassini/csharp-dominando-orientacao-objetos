using ScreenSound_Refatorado.Modelos;

namespace ScreenSound_Refatorado.Menu;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Exibir detalhes da banda");
            Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
                /**
                * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
                */
                Console.WriteLine("Digite uma tecla para votar ao menu principal");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
