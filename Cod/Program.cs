/*Написать программу, которая из имеюшегося массива строк формирует массив из строк,
 длина которых <=3 символа.*/

string[] arrayInput = GetArrayStringRandom();
int len = arrayInput.Length; //длина имеющегося массива
int size = 0; //количество элементов нового массива
size = lengthArrayOutput(arrayInput); //подсчет элементов, удовлетворяющих условию
string[] arrayOutput = new string[size]; //задание нового массива
arrayOutput = FillArray(arrayInput, arrayOutput); //заполнение нового массива
Console.Write($"Имеющийся массив из {arrayInput.Length} строк");

if (arrayInput.Length % 10 == 1 && arrayInput.Length != 11) Console.Write("и");
Console.WriteLine(":\n");
PrintArray(arrayInput);
if (arrayOutput.Length != 0) //ПРОВЕРКА, сформирован ли итоговый массив
{
    Console.Write($"Сформирован массив из {arrayOutput.Length} строк");
    if (arrayOutput.Length % 10 == 1 && arrayOutput.Length != 11) Console.Write("и");
    Console.Write(" c длиной, меньшей либо равной 3:\n"); //вывод полученного массива
    PrintArray(arrayOutput);
}
else Console.WriteLine("[] \n\nСтрок, длина которых меньше либо равна 3, нет. "); //вывод сообщения о несформированности массива
Console.WriteLine("\n"); Console.ReadKey();

string[] GetArrayStringRandom() //МЕТОД СОЗДАНИЯ МАССИВА СЛУЧАЙНОГО КОЛИЧЕСТВА СТРОК СЛУЧАЙНОЙ ДЛИНЫ ИЗ СЛУЧАЙНЫХ СИМВОЛОВ
{
    Random random = new Random();
    int lengthArray = random.Next(1, 101);
    string[] array = new string[lengthArray];
    for (int i = 0; i < lengthArray; i++)
    {
        string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#$%&'()*+,-\"./:;<=>?@[]^_'{|}~";

        int lengthString = random.Next(1, 10);
        for (int j = 0; j < lengthString; j++)
        {
            int numberSymbol = random.Next(0, symbols.Length - 1);
            array[i] = array[i] + symbols.Substring(numberSymbol, 1);
        }
    }
    return array;
}

int lengthArrayOutput(string[] array) //функция определения длины нового массива
{
    int counter = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
        if (array[i].Length <= 3) counter++;
    return counter;
}

string[] FillArray(string[] array1, string[] array2) // функция заполнения нового массива в соотвестввии с условием задачи
{
    int size = array1.Length;
    int i = 0;
    int j = 0;
    while (i < size)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
        i++;
    }
    return array2;
}

void PrintArray(string[] matrix) //метод вывода массива в консоль
{
    Console.Write(" ");
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green; Console.Write($"\"{matrix[i]}\""); Console.ResetColor();
        if (i == matrix.Length - 1) Console.Write("]");
        else Console.Write(", ");
    }
    Console.WriteLine("\n");
}




