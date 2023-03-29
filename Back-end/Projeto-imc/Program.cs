Console.BackgroundColor = ConsoleColor.Yellow; // Cor de fundo do texto abaixo
Console.WriteLine(@$"
  __  __            _  _      _                    _         _____  __  __   _____  
 |  \/  |          | |(_)    | |                  | |       |_   _||  \/  | / ____| 
 | \  / |  ___   __| | _   __| |  ___   _ __    __| |  ___    | |  | \  / || |      
 | |\/| | / _ \ / _` || | / _` | / _ \ | '__|  / _` | / _ \   | |  | |\/| || |      
 | |  | ||  __/| (_| || || (_| || (_) || |    | (_| ||  __/  _| |_ | |  | || |____  
 |_|  |_| \___| \__,_||_| \__,_| \___/ |_|     \__,_| \___| |_____||_|  |_| \_____| 

");
Console.ResetColor(); // Impede da cor continuar pelo código

Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("Insira seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Insira seu peso:");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine("Insira sua altura:");
float altura = float.Parse(Console.ReadLine());

Console.ResetColor();

float imc = peso / ((float)Math.Pow(altura, 2));

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"O imc do {nome} é de {imc}");
Console.ResetColor();