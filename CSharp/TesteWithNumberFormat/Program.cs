// O C# formata datas, numeros e datas de acordo com o O código de cultura aonde o computador esta sendo executado.

// formtando dinheiro.
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C}) \n");


// formatando numeros. Por padrão ele formata para 2 casa decimais
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units \n");


// Mais se você quiser almentar a precisaõ basta colocar a quantidade de casa depois do ':N'
decimal measurement2 = 123456.78912m;
Console.WriteLine($"Measurement: {measurement2:N4} units \n");


// Formatar percentuais
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2} \n");


// ---------------------------------Testes----------------------------------------------
int invoiceNumber = 1201;
decimal productMeasurement = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Due: {total:C}");
