// Задача 64: Выполнить с помощью рекурсии.Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
// Console.Write("Введи число: ");
// int n  = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(n,1));
// // ------------------Метод------------------
// string PrintNumbers(int end, int start){
//     if(end == start) return end.ToString();
//     return (end + " " + PrintNumbers(end -1, start));
// }

//Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.Write("Введи число m: ");
// int m  = int.Parse(Console.ReadLine()!);
// Console.Write("Введи число n: ");
// int n66  = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма чисел от {m} до {n66}: {SumNumbers(m,n66)}");
// // ------------------Метод------------------
// int SumNumbers(int m, int n){
//     if(m==n) return m;
//     return n+SumNumbers(m, n-1);
//}

//Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана
//с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Введи число m: ");
int m68  = int.Parse(Console.ReadLine()!);
Console.Write("Введи число n: ");
int n68  = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Функция Аккермана для чисел {m68} и {n68}: {AkkermanFunction(m68,n68)}");

//----------Метод---------
int AkkermanFunction(int m, int n){
    if(m==0) return n+1;
    if(n==0) return AkkermanFunction(m-1,1);
    return AkkermanFunction(m-1, AkkermanFunction(m, n-1));
}