// Insira Frequencia (%) (apenas numeros)

// Insira a media

// Se (frequencia >= 0.75) && (media >= 7.0)
// APROVADO 

// Se nao (frequecia >= 0.75) && (media >= 3)
// RECUPERACAO

// else
// REPROVADO

double frequencia;

double media;

Console.WriteLine($"Insira Frequencia (%) (apenas numeros):");

frequencia = double.Parse(Console.ReadLine());

Console.WriteLine($"Insira a media:");

media = double.Parse(Console.ReadLine());

if ((frequencia >= 75) && (media >= 7))
{
    Console.WriteLine($"APROVADO");
}

else if ((frequencia >= 75) && (media >= 3))
{
    Console.WriteLine($"RECUPERACAO");
}

else 
{
    Console.WriteLine($"REPROVADO");
}

