Console.WriteLine("Digite um valor:");

if (!int.TryParse(Console.ReadLine(), out int value))
{
  Console.WriteLine("Entrada invalida. Digite um numero inteiro.");
  return;
}

List<int> values = FiboValues(value);
Console.WriteLine(string.Join(", ", values));

static List<int> FiboValues(int number, int previous = 0, int current = 1, List<int>? numbers = null)
{
  numbers ??= [];

  if (number <= 0)
  {
    return numbers;
  }

  numbers.Add(previous);
  return FiboValues(number - 1, current, current + previous, numbers);
}
