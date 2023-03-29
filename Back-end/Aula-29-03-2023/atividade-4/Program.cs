Console.WriteLine(@$"

   ___        _       _                  _             _         _____      
  / _ \ _   _(_)_ __ | |_ __ _ _ __   __| | __ _    __| | ___   |__  /_/__   
 | | | | | | | | '_ \| __/ _` | '_ \ / _` |/ _` |  / _` |/ _ \    / // _ \  
 | |_| | |_| | | | | | || (_| | | | | (_| | (_| | | (_| | (_) |  / /|  __/  
  \__\_\\__,_|_|_| |_|\__\__,_|_| |_|\__,_|\__,_|  \__,_|\___/  /____\___|  
                                                                            
---------------------------------------------------------------------------- 
");


Console.WriteLine("R$ 25,00 o quilo (kg)");
float valorDoKg = 25.0f;

Console.Write($"Insira o peso que deseja levar do alimento (em kg): ");
float peso = float.Parse(Console.ReadLine());

float valorTotal = valorDoKg * peso;

Console.WriteLine($"Valor total: R$ {valorTotal.ToString("N2")} por {peso}kg");