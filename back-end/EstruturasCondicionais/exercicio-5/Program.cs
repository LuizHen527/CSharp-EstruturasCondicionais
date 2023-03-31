// - Insira a quantidade de maçãs
// - If (quantidadeMacas < 12)
// - preco = (quantidadeMacas * 30) / 100
// - O total a pagar: R$ preco 

// - else
// - preco = (quantidadeMacas * 25) / 100
// - O total a pagar: R$ preco 

int quantidadeMacas;
double preco;

Console.WriteLine($"Insira a quantidade de maçãs:");

quantidadeMacas = int.Parse(Console.ReadLine());

if (quantidadeMacas < 12)
{
    preco = ((quantidadeMacas *30) / 100.0);
    Console.WriteLine($"Total a pagar: R$" + preco);
}

else
{
    preco = ((quantidadeMacas * 25) / 100.0);
    Console.WriteLine($"Total a pagar: R$" + preco);
}
