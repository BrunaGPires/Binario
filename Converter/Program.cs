Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

List<int> resultado = new List<int>();
while (numero > 0 )
{
    int resto = numero % 2;
    resultado.Insert(0, resto);
    numero /= 2;
}

while (resultado.Count < 8)
{
    resultado.Insert(0, 0);
}

Console.WriteLine($"O número {numero} em binário é:");
foreach (int valor in resultado)
{
    Console.Write(valor);
}