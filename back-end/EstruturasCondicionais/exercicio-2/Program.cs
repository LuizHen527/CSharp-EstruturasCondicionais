// - Insira a pontuacao do primeiro time:
// - Insira a pontuacao do segundo time 
// - Se pontuacao1 > pontuacao2, Primeiro Time venceu
// - Else If pontuacao2 > pontuacao1, Segundo Time venceu
// - Else, empate

int pontuacao1;
int pontuacao2;

Console.WriteLine("Insira a pontuacao do primeiro time:");

pontuacao1 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira a pontuacao do segundo time:");

pontuacao2 = int.Parse(Console.ReadLine());

if (pontuacao1 > pontuacao2)
{
    Console.WriteLine($"Primeiro Time venceu");
    
}

else if (pontuacao2 > pontuacao1)
{
    Console.WriteLine($"Segundo Time venceu");
}

else
{
        Console.WriteLine($"Empate");
}