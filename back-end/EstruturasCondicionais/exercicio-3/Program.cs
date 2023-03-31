// - Insira a primeira medida do triangulo:
// - Insira a segunda medida do triangulo:
// - Insira a terceira medida do triangulo:
// - If medida1 == medida2 && medida2 == medida3,
// Esse e um Triângulo Equilátero
// - Else if (medida1 == medida2) || (medida1 == medida3) || (medida3 == medida2)
// Esse e o triangulo Isosceles
// - Else 
// Esse e um triangulo Escaleno

float medida1;
float medida2;
float medida3;

Console.WriteLine($"Insira a primeira medida do triangulo:");

medida1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira a segunda medida do triangulo:");

medida2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira a terceira medida do triangulo:");

medida3 = float.Parse(Console.ReadLine());

if ((medida1 == medida2) && (medida2 == medida3))
{
    Console.WriteLine("Esse é um Triângulo Equilátero");
}

else if ((medida1 == medida2) || (medida1 == medida3) || (medida3 == medida2))
{
    Console.WriteLine("Esse é um Triângulo Isósceles");
}

else 
{
    Console.WriteLine($"Esse é um Triângulo Escaleno");
}