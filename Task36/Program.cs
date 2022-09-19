//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[size];
int sum = 0;
FillRandomArray(arr);
PrintArr(arr);

for (int j = 1; j < arr.Length; j = j + 2){
        sum = sum + arr[j];
}

Console.WriteLine($"Суммы нечетных чисел = {sum}");

void FillRandomArray (int[] arr){
    for ( int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(0, 1000);
    }
}

void PrintArr (int[] arr){
    Console.Write("Ваш массив: [ ");
    for (int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");       
}
