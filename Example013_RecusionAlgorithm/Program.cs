﻿string[,] table = new string[2,5];
//    table[0,0]  table[0,1]   table[0,2]  table[0,3]  table[0,4] Две строки и пять столбцлв индексы с 0
//    table[1,0]   table[1,1]  table[1,2]  table[1,3]  table[1,4] 

// table[1,2] = "word"; 

// for (double rows = 0; rows < 2; rows++)
// {
//     for (double columns = 0; columns < 5; columns++)
//     {
//         Console.Write($"-{table[rows, columns]}-");
//     }
// }


// void PrintArray(double[,] image)
// {
// for (double i =0; i < image.GetLength(0); i++)
// {
//     for (double j = 0; j < image.GetLength(1); j++)
//     {
//         Console.Write($"{image[i,j]} ");
//     }
//     Console.WriteLine();
// }
// }
// void FillArray(double[,] image)
// {
//     for (double i = 0; i < image.GetLength(0); i++)
//     {
//         for (double j = 0; j < image.GetLength(1); j++)
//         {
//             image[i,j] = new Random().Next(1,10); // [1;10) 10 не входит в интервал
//         }
//     }
// }
// double[,] matrix = new double[3,4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
// double[,] pic = new double[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(double[,] image)
// {
//     for (double i = 0; i < image.GetLength(0); i++)
//     {
//         for (double j = 0; j < image.GetLength(1); j++)
//         {
//             //Console.Write($"{image[i,j]} ");
//             if(image[i,j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }
// void FillImage(double row, double col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col-1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }
// PrintImage(pic);
// FillImage(13,13);
// PrintImage(pic);

// double Factorial (double n)
// {
//     if (n == 1) return 1; // 1! = 1, 0! = 1
//     else return n * Factorial(n - 1);
// }
// for (double i = 1; i < 40; i++)
// Console.WriteLine($"{i}! = {Factorial(i)}"); 

// Пример рекурсии, последовательность Фибоначчи, где каждое следующее число задается как сумма двух предыдущих
// 1 1 2 3 5 8 13 21 ... 
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2); f(3) = f(3 - 1) + f(3 - 2) = 3,  f(4) = f(4 - 1) + f(4 - 2) = 5, и т.д.

double Fibonacci (double n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + (n - 2);
}
for (double i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
