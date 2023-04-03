Console.Write($"Digite apenas uma letra: ");
char letter = char.Parse(Console.ReadLine().ToLower());

if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'o')
    Console.Write("É uma vogal.");
else
    Console.Write("É uma consoante.");
