// See https://aka.ms/new-console-template for more information


string[] Foods = {"Pane", "Acqua", "Ciccio", "Anguria", "Arancia", "Pasta", "Pizza"};

Console.WriteLine($"N: {Foods.Length}");

foreach (string Food in Foods)
{
    Console.WriteLine(Food);
}


Console.WriteLine($"Primo Elemento: {Foods[(Foods.Length -1) - (Foods.Length - 1)]}");
Console.WriteLine($"Ultimo Elemento: {Foods[Foods.Length-1]}");

Console.ReadLine();
