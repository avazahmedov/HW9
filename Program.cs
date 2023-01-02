// Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.

    // void TentoTwo(int num)
    // {
    //     if (num >1)
    //     TentoTwo(num/2);
    //     System.Console.Write(num%2);
    // }

    // Console.Write("Enter number: ");
    // int num = Convert.ToInt32(Console.ReadLine());
    // TentoTwo(num);
    

// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// int RecursSumm(int M, int N)
// {
//     if (Math.Max(M, N) != Math.Min(M,N))
//     return RecursSumm(Math.Min(M,N),Math.Max(M, N)-1) + Math.Max(M,N);
//     else return 0;
// }

// Console.Write("Enter M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum = RecursSumm(M, N);
// Console.WriteLine(sum+Math.Min(M,N));