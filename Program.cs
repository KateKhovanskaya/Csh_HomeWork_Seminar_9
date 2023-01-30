// Задача 64: Выполнить с помощью рекурсии.Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
Console.Write("Введи число: ");
int n  = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(n,1));
// ------------------Метод------------------
string PrintNumbers(int end, int start){
    if(end == start) return end.ToString();
    return (end + " " + PrintNumbers(end -1, start));
}