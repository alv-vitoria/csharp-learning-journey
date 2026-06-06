// Passo 1 — pedir a temperatura
Console.WriteLine("Digite a temperatura em Celsius:");

// Passo 2 — ler e guardar como double
string textoCelsius = Console.ReadLine();
double celsius = double.Parse(textoCelsius);

// Passo 3 — calcular
double fahrenheit = celsius * 9/5 + 32;

// Passo 4 — mostrar
Console.WriteLine("Em Fahrenheit: " + fahrenheit);

Console.WriteLine("Digite a temperatura em Celsius:");

string textoCelsius = Console.ReadLine();
double celsius = double.Parse(textoCelsius);

double fahrenheit = celsius * 9/5 + 32;

Console.WriteLine("Em Fahrenheit: " + fahrenheit);
