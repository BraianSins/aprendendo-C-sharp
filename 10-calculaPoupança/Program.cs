using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10- Calcula Poupança");


        double investimento = 1000;
        //rendimento de 0.5% (0.005) ao mês
        //mes 1
        //investimento = investimento + investimento * 0.05;
        //mes 2
        //investimento = investimento + investimento * 0.05;
        //mes 3
        //investimento = investimento + investimento * 0.05;

        Console.WriteLine(investimento);


        int mes = 1;
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.05;
            Console.WriteLine("No mês " + mes + " voce tem R$" + investimento);

            mes++;

        }


        Console.WriteLine("Tecle enter para sair da tela");
        Console.ReadLine();

    }

}

