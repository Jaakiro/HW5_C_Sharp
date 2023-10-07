// (DONE) Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет количество
//  чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Enter array size");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// int count = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     count++;
// }

// Console.WriteLine($"Quantity of even numbers in the array -> {count} ");

// void CreateRandomArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// CreateRandomArray(numbers);
// PrintArray(numbers);


// (DONE) Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int size = 4;
// int[] numbers = new int[size];
// RandomNumArray(numbers);
// PrintArray(numbers);

// int SumIndex = 0;

// for (int i = 1; i < numbers.Length; i += 2)
// {
//     SumIndex += numbers[i];
// }
// Console.Write(SumIndex);

// void RandomNumArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }



// (DONE) Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



// void Array(int number) 
// {
// double [] numbers = new double[number]; 
// double min = Int32.MaxValue;
// double max = Int32.MinValue; 
// Console.Write("[");	  		     
//     for (int i = 0; i < number-1; i++)
//     {
//      numbers [i] = Convert.ToDouble(new Random().Next(-1000,1000)) / 100;        
//     Console.Write(numbers [i] + ", ");
//         if (numbers[i] > max) {max = numbers[i];}
//         if (numbers[i] < min) {min = numbers[i];}
//         }	  
//          numbers [number-1] = Convert.ToDouble(new Random().Next(-1000,1000)) / 100;
//             if (numbers[number-1] > max) {max = numbers[number-1];}
//             if (numbers[number-1] < min) {min = numbers[number-1];}
        
//     Console.Write(numbers [number-1] + "] => " + max + " - (" + min + ") = "  + (max - min));
     
// }	  
	
// {
// Console.Write("Enter numbers array: ");
// int VvodNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Difference between max and min elements array: ");
// Array(VvodNumber);
// }
	

