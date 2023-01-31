//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
string[] array = new string[N];

//FillArray(array); // создать
VvodArray(array);  //ввести/изменить
PrintArray(array); //вывод

void VvodArray(string[] array)
{
    for (int i = 0; i < N; i++)
{
    Console.WriteLine("Введите {0}-й элемент", i + 1);
    array[i] = Convert.ToString(Console.ReadLine());
}
}

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 100);
// }

void PrintArray(string[] array)

{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void 

  

  