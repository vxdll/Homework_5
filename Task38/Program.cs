//Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите размер массива:");
int size =  Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
Console.WriteLine("Введите порядок чисел через запятую (','): ");
string[] arrayNumber = Console.ReadLine().Split(",");

for (int i = 0; i < arrayNumber.Length; i++){
    arr[i] = int.Parse(arrayNumber[i]);
}

// Результат зависит от массива указанного пользователем.
Diff(arr); 

// Результат при использовании псевдослучайных чисел, но с учетом заданой длинны массива пользователем.
FillRandomArray(arr);
PrintArr(arr);
Diff(arr);


//Используемые методы:
void Diff (int[] arr){
    int max = arr[0];
    int min = arr[0];
    int result = 0;
    for (int i = 0; i < arr.Length; i++){
         if(arr[i] > max) max = arr[i];
         if(arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"Максимальное значение массива = {max}");
    Console.WriteLine($"Минимальное значение массива = {min}");
    result = max - min;
    Console.WriteLine($"Разница между максимальным значением и минимальным составляет: {result}");
}

void FillRandomArray (int[] arr){
    for ( int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(0, 1001);
    }
}

void PrintArr (int[] arr){
    Console.Write("Ваш массив: [ ");
    for (int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");       
}

