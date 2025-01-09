
//aplikacjia ma na zadaniu nasladowanie prostego kalkulatora 
//lecz znjaduje w nim sie blad logiczny
//cos nie tak jest w jednym z dzialan matematycznych
int num1 = 0; int num2 = 0;


Console.WriteLine("Prosty kalkulator");
Console.WriteLine("----------------\n");

Console.WriteLine("Wybierz liczbę na klawiaturze i wcisnij enter ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Wybierz drugą liczbę na klawiaturze i wcisnij enter ");
num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Wybierz co chcesz zrobic ze swoimi liczbami ");
Console.WriteLine("\tw - Dodać");
Console.WriteLine("\ts - Odjąć");
Console.WriteLine("\ta - pomnozyc");
Console.WriteLine("\td - podzielic");

switch (Console.ReadLine())
{
    case "w":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num2 - num1));
        break;
    case "a":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}
Console.WriteLine("Nacisnij dowolny przycisk by zakonczyc ten program");
Console.ReadKey();
