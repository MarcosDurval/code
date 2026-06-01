Console.WriteLine("Escreva o texto:");
string? text = Console.ReadLine();

if (string.IsNullOrEmpty(text))
{
  return;
}

string newText = ClearValue(text);
Console.WriteLine(newText);

static string ClearValue(string text)
{
  string newText = text[0].ToString();
  int count = 1;

  while (count < text.Length)
  {
    bool isRepeatedPunctuation = text[count] == text[count - 1]
      && (text[count] == '?' || text[count] == '!');

    if (!isRepeatedPunctuation)
    {
      newText += text[count];
    }

    count++;
  }

  return newText;
}
