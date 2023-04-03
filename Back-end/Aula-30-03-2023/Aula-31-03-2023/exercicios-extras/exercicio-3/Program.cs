// Values reading
Console.Write("Insira o raio de da circunferência: ");
float circumferenceRadius = float.Parse(Console.ReadLine());

// Calculates the diameter
float diameter = circumferenceRadius * circumferenceRadius; // d = r*r

// Calculates the width
float lenght = 2 * (float)Math.PI * circumferenceRadius; // C=2*pi*r

// Calculates the area
float area = (float)Math.PI * (circumferenceRadius * circumferenceRadius); // a = pi*r*r

Console.WriteLine(@$"
Diâmetro da circunferência: {diameter.ToString("N2")};
Comprimento da circunferência: {lenght.ToString("N2")};
Area da circunferência: {area.ToString("N2")};
");