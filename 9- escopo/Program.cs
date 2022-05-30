using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7- Condicionais");

        int idadeJoao = 16;
        int quantidadeDePessoas = 2;

        bool acompanhado = quantidadeDePessoas > 1;

        string textoAdicional;

        if(acompanhado == true)
        {
            textoAdicional = "joao está acompanhado";
        }
        else
        {
            textoAdicional = "joao precisa estar acompanhado";
        }


        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar!");
            Console.WriteLine(textoAdicional);
        }

        else
        {
            Console.WriteLine("Não pode entrar");
        }

        Console.WriteLine("Tecle enter para sair da tela");
        Console.ReadLine();

    }

}
