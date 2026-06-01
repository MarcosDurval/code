Console.WriteLine("Digite uma frase:");
string? phrase = Console.ReadLine();

if (string.IsNullOrWhiteSpace(phrase) || phrase.Length < 3)
{
  Console.WriteLine("Escreva uma frase com pelo menos 3 caracteres.");
  return;
}

if (IsPalindrome(phrase))
{
  Console.WriteLine($"A frase '{phrase}' e um palindromo.");
}
else
{
  Console.WriteLine($"A frase '{phrase}' nao e um palindromo.");
}

static bool IsPalindrome(string phrase)
{
  int left = 0;
  int right = phrase.Length - 1;

  while (right > left)
  {
    while (right > left && !char.IsLetterOrDigit(phrase[left]))
    {
      left++;
    }

    while (right > left && !char.IsLetterOrDigit(phrase[right]))
    {
      right--;
    }

    if (!string.Equals(
      phrase[right].ToString(),
      phrase[left].ToString(),
      StringComparison.OrdinalIgnoreCase))
    {
      return false;
    }

    left++;
    right--;
  }

  return true;
}
