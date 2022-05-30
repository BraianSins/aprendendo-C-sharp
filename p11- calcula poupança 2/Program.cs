using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11- Calcula Poupança");


        //double investimento = 1000;

        //Console.WriteLine(investimento);


        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.05;
            Console.WriteLine("No mês " + mes + " voce tem R$" + investimento);

            mes++;

        }
        */

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " voce tem R$" + investimento);
        }

        Console.WriteLine("Tecle enter para sair da tela");
        Console.ReadLine();

    }

}

