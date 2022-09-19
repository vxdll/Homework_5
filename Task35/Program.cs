//Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

int [] arr = new int [123];
int count = 0;
FillRandomArray(arr);
PrintArr(arr);

for (int j = 0; j < arr.Length; j++){
    if( arr[j] >= 10 & arr[j] <= 99){
        count = count + 1;
    }
}

Console.WriteLine($"Всего чисел {arr.Length} из них в диапазоне [10, 99] -> {count}");

void FillRandomArray (int[] arr){
    for ( int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(0, 151);
    }
}

void PrintArr (int [] arr){
    Console.Write("Ваш массив: [ ");
    for (int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");       
}

