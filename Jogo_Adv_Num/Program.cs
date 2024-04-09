
Console.WriteLine(" ╔══════════════════════════════════════════════════╗ ");
Console.WriteLine(" ║                   Bem-Vindo(a)!                  ║ ");
Console.WriteLine(" ╚══════════════════════════════════════════════════╝ ");

Console.WriteLine(" ╔══════════════════════════════════════════════════╗ ");
Console.WriteLine(" ║              PROGRAMA EM C# (2024)               ║ ");
Console.WriteLine(" ╚══════════════════════════════════════════════════╝ ");

Console.WriteLine(" ╔══════════════════════════════════════════════════╗ ");
Console.WriteLine(" ║             JOGO DE ADVINHAÇÃO DE NÚMEROS        ║ ");
Console.WriteLine(" ╚══════════════════════════════════════════════════╝ ");

Console.WriteLine(" ╔══════════════════════════════════════════════════╗ ");
Console.WriteLine(" ║              GUSTAVO SOUZA NAPPI                 ║ ");
Console.WriteLine(" ╚══════════════════════════════════════════════════╝ ");

Random random = new Random();
bool JogarNovamente = true;
int min = 1;
int max = 100;
int advinhar;
int numero;
int advinhações;
string resposta;

while(JogarNovamente)
{
    advinhar = 0;
    advinhações = 0;
    numero = random.Next(min,max + 1);
    resposta = "";

    while(advinhar != numero)
    {
        Console.Write(" Advinhe um número " + min + " - " + max + " : " );
        advinhar = Convert.ToInt32(Console.ReadLine());

        if(advinhar > numero)
        {
            Console.WriteLine(advinhar + " MUITO ALTO ! ");
        }
        else if (advinhar < numero)
        {
            Console.WriteLine(advinhar+" MUITO BAIXO ! ");
        }
        advinhações ++;
    }
    Console.WriteLine("Número: " + numero);
    Console.WriteLine("VOCÊ VENCEU!");
    Console.WriteLine("Advinhações: " + advinhações);
    Console.WriteLine("QUER JOGAR NOVAMENTE?? (Y/N): ");
    resposta = Console.ReadLine();
    resposta = resposta.ToUpper();
    
    if (resposta == "Y")
    {
        JogarNovamente = true;
    }
    else 
    {
        JogarNovamente = false;
    }
    

}
Console.WriteLine("OBRIGADO POR JOGAR! ");




Console.ReadKey();
