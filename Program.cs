/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
// int[] FillArrayWhithRandomNumber(int size)
// {
// int[] arr = new int[size];
// Random rnd = new Random();
// for(int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(100, 1000);
// }
// return arr;
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWhithRandomNumber(size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");

// int count = 0;
// for(int i = 0; i < array.Length; i++)
// {
// if(i%2 == 0)
// count++;
// }

// System.Console.WriteLine(count);

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

// int[] FillArrayWhithRandomNumber(int size)
// {
// int[] arr = new int[size];
// Random rnd = new Random();
// for(int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(-10, 11);
// }
// return arr;
// }

// System.Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWhithRandomNumber(size);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");


// int count = 0;
// for(int i = 0; i < array.Length; i++)
// {if (i%2!=0)
//     count+=array[i];
// }
// System.Console.WriteLine(count);

/*Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между 
максимальным и минимальным элементов массива.
[3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1*/

int[] FillArrayWhithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(1, 11);
}
return arr;
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWhithRandomNumber(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");

int max=array[0];
int min=array[0];

for (int i=1; i<array.Length;i++) 
{
   if(max<array[i])
   {max=array[i];}
   if (array[i]<min)
   {min=array[i];}
}
    // int sum=min;
    // while (min<max)
    // {
    //  sum+=sum;
    //  }  


Console.WriteLine ($"Максимальное число {max}, минимальное число {min} ");

