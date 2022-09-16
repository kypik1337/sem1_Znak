// на вход принимает два числа и провиряет квадрат второго числа
Console.WriteLine("add number1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("add number2");
int number2 = int.Parse(Console.ReadLine());
// раблтаем через библию

if (Math.Pow(number2, 2) == number1)
    {
    Console.WriteLine("number1 tru number2");
    }
else 
    {
        Console.WriteLine("number1 folse number2");
    }
    