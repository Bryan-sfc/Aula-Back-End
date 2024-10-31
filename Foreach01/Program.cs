string[] frutas = {"Melancia", "Carambola", "Maracujá", "Morango", "Limão", "Jabuticaba", "Abacate", "Kiwi", "Acerola", "Pinha", "Lichia", "Pitaya", "Pêssego", "Banana"};

Console.Write($"Sua sacola contém {frutas.Length} Frutas: ");

foreach (string f in frutas)
{
    Console.Write($"{f}, ");
}