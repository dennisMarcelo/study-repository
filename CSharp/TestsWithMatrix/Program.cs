// ---------------Ordenação de matriz---------------------

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");

Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}





// ---------------Métodos de limpeza e redimencionamento de matriz---------------------
Console.WriteLine("");

// O método Clear remove o valor dentro da matriz, mas a matriz continua com o mesmo length e 
// e as posições ficam nulas 
string[] pallets2 = { "B14", "A11", "B12", "A13" };
Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets2, 0, 2);
Console.WriteLine($"After: {pallets2[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets2.Length}");
foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}


// método Rezsize adiciona redimenciona o array para 6 posições
Console.WriteLine("");

Array.Resize(ref pallets2, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets2.Length}");
pallets2[4] = "C01";
pallets2[5] = "C02";

foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}


// O método Resize tbm remove elementos utilizando um length menor que o atual
Console.WriteLine("");

Array.Resize(ref pallets2, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets2.Length}");

foreach (var pallet in pallets2)
{
    Console.WriteLine($"-- {pallet}");
}

/*
    Não tem um método para limpar os valores nulos de um array, o que siginifica que vou ter que implementar este método na mão.
    Dica: "A melhor maneira de fazer isso é contar o número de elementos não nulos iterando em cada item e incrementar uma
    variável (um contador). Em seguida, você criará uma segunda matriz que tem o tamanho da variável do contador. Por fim, 
    você executará um loop em cada elemento na matriz original e copiará valores não nulos na nova matriz." - doc microsoft
*/