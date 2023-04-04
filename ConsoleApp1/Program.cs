// See https://aka.ms/new-console-template for more information


string[] Foods = {"Pane", "Acqua", "Ciccio", "Americana", "Arancia", "Pasta", "Pizza"};

Console.WriteLine($"N: {Foods.Length}");

foreach (string Food in Foods)
{
    Console.WriteLine(Food);
}


Console.WriteLine($"Primo Elemento: {Foods[0]}");
Console.WriteLine($"Ultimo Elemento: {Foods[Foods.Length-1]}");

//Pari
if(Foods.Length % 2 == 0)
    Console.WriteLine($"Elementi in Mezzo: {Foods[(Foods.Length - 1) / 2]} Centro 2: {Foods[(Foods.Length - 1) / 2 + 1]}");
else
    Console.WriteLine($"Elemento in Mezzo: {Foods[(Foods.Length - 1) / 2]}");

Console.ReadLine();


