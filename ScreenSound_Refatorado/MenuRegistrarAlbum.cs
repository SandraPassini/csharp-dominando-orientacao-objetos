﻿using ScreenSound_Refatorado.Menu;
using ScreenSound_Refatorado.Modelos;

internal class MenuRegistrarAlbum : Menu
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.Write("Agora digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;
        /**
         * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
         */
        Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}