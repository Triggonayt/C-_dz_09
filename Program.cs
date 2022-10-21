// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Enter number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int m = 1;
// Console.WriteLine(find(n, m));

// int find (int number, int target)
// {
//     Console.WriteLine(number);
//     if (number == target) return number;
//     else return find(number - 1, target);
    
// }


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Clear();
// Console.WriteLine("Enter number M:");
// int M = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter number N:");
// int N = int.Parse(Console.ReadLine());

// void GapNumberSum (int M, int N, int sum)
// {
//     if (M > N) 
//     {
//         Console.WriteLine($"The sum of natural elements from M to N: {sum}"); 
//         return;
//     }
//     sum = sum + (M++);
//     GapNumberSum(M, N, sum);
// }

// GapNumberSum(M, N, 0);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



Console.WriteLine("Enter number M:");
int numM = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number N:");
int numN = int.Parse(Console.ReadLine());

int AckermannFunction (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM != 0 && numN == 0) return AckermannFunction(numM - 1, 1);
    if (numM > 0 && numN > 0) return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
return AckermannFunction(numM, numN);
}

Console.WriteLine($"Ackerman function({numM},{numN}) = {AckermannFunction(numM, numN)}");