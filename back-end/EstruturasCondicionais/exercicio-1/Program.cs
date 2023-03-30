// - Informe salario
// - Informe total gasto
// - Se salario >= total gasto, “Gastos dentro do orçamento”
// - Se nao, “Orçamento estourado”

float salario;
float totalGasto;

Console.WriteLine($"Informe seu salario:");

salario = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o total gasto:");

totalGasto = float.Parse(Console.ReadLine());

if(salario >= totalGasto)
{
    Console.WriteLine("Gastos dentro do orçamento");
}

else 
{
    Console.WriteLine("Orçamento estourado");
}