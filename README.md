# LeetCode em C#

Este repositorio contem estudos e solucoes de problemas do LeetCode usando C#.

A organizacao e simples: cada problema fica em uma pasta propria com um `Program.cs`.

## Estrutura

```text
.
├── ClearString/
├── Fibo/
├── IsPrimo/
├── MinElement/
└── Palindromo/
```

## Como executar

Alguns arquivos foram escritos como programas C# completos e podem ser executados diretamente com o .NET SDK 10 ou superior:

```sh
dotnet run --file Fibo/Program.cs
dotnet run --file IsPrimo/Program.cs
dotnet run --file Palindromo/Program.cs
dotnet run --file ClearString/Program.cs
```

Outros arquivos seguem o formato usado pelo LeetCode, com a classe `Solution`. Esses arquivos devem ser copiados/submetidos na plataforma:

```text
MinElement/Program.cs
```

## Observacao

Nao e necessario manter `.csproj` ou `.sln` para estes exercicios. O objetivo do repositorio e manter as solucoes pequenas, diretas e faceis de revisar.
