// Soma todos os numeros primos ate o numero informado.
// Exemplo: 10 => 2 + 3 + 5 + 7 = 17.

Console.WriteLine("Digite um numero:");

if (!int.TryParse(Console.ReadLine(), out int number))
{
  Console.WriteLine("Entrada invalida. Digite um numero inteiro.");
  return;
}

int result = 0;
int current = 2;

while (current <= number)
{
  if (IsPrime(current))
  {
    result += current;
    Console.WriteLine($"{current} e um numero primo.");
  }
  else
  {
    Console.WriteLine($"{current} nao e um numero primo.");
  }

  current++;
}

Console.WriteLine($"Valor final: {result}");

static bool IsPrime(int number)
{
  if (number < 2)
  {
    return false;
  }

  for (int i = 2; i <= Math.Sqrt(number); i++)
  {
    if (number % i == 0)
    {
      return false;
    }
  }

  return true;
}
