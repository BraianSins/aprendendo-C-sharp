
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12- Investimento a Longo Prazo");


        double fatorRendimento = 1.005;
        double investimento = 1000;
        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++) ;
        {
                investimento *= fatorRendimento;
            }

            fatorRendimento += 0.01;

        }

        Console.Write("depois de 5 anos você terá " + investimento);
        Console.Write("tecle enter para fechar");
        Console.ReadLine();

    }

}