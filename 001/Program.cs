// задача в которой будет число умножаться на себя(возводиться в квадрат)
Console.WriteLine("Write number");
int number = int.Parse(Console.ReadLine());
//возведение в квадрат математическим методом
int sqr = number * number;
Console.WriteLine($"square number {number} = {sqr}");
//$ это текст + переменные 
// Метод с помощью библиотеки

int sqr1 = Convert.ToInt32(Math.Pow(number, 3));
Console.WriteLine($"square number {number} = {sqr1}");

