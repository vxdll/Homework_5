//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[size];
int count = 0;
FillRandomArray(arr);
PrintArr(arr);

for (int j = 0; j < arr.Length; j++){
    if( arr[j] % 2 == 0){
        count = count + 1;
    }
}

Console.WriteLine($"Всего чисел {arr.Length} из которых четных -> {count} ");

void FillRandomArray (int[] arr){
    for ( int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(100, 1000);
    }
}

void PrintArr (int [] arr){
    Console.Write("Ваш массив: [ ");
    for (int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");       
}

