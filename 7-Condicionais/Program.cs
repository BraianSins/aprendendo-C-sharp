using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7- Condicionais");

        int idadeJoao = 16;
        int quantidadeDePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (quantidadeDePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado, então pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }
        }
        Console.WriteLine("Tecle enter para sair da tela");
        Console.ReadLine();

    }

}
