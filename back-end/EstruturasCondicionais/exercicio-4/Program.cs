// - Escreva sua senha 
// - if (senha = senhaValida)
// Acesso permitido
// - Else 
// Acesso negado

int senhaValida = 1234;
int senha;

Console.WriteLine($"Digite sua senha:");

senha = int.Parse(Console.ReadLine());

if (senhaValida == senha)
{
    Console.WriteLine($"ACESSO CONCEDIDO");
}

else
{
    Console.WriteLine($"ACESSO NEGADO");
}
