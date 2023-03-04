// 1. Не принимает никаких аргументов и ничего не возвращает
void Metod1()
{
Console.WriteLine("Автор ... ");
}
Metod1();

// 2. Принимает какие-то аргументы, но ничего не возвращает

void Metod2(string msg) - //где void ключевое слово, дальше идентификатор, в скобках указаны какие-то аргументы.

{
Console.WriteLine(msg); - //оператор, в скобках указан принятый аргумент.
}
Metod2("Текст сообщения"); - //где Metod2 является идентификатором, а в скобках указан текст, выводимый в консоли.

// Именованные аргументы - явно может быть указано какому аргументу, какое значение мы хотим указать

void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg); //где переменная count отображает на экране определённое количество сообщений msg.
        i++;
    }
}
Metod21("Текст", 4); //метод вызывает Текст, после запятой указано количество вызовов, в нашем случае 4

// можно явно указывать к какому аргументу, какое значение мы хотим присвоить:
Было: Metod21(“Текст”, 4);
Стало: Metod21(msg: “Текст”, count: 4);
//Явно указывая наименование аргумента, не обязательно писать их по порядку.
Metod21(count: 4, msg: "Текст");

//3. Может что-то возвращать, но не принимает никаких аргументов. Например, может служить для генерации случайных данных.
int Metod3() // не принимает никакие аргументы
{
    return DateTime.Now.Year; // обязательное использование оператора return,
}
int year = Metod3(); // вызываем метод, в левой части используем идентификатор переменной (year) и через оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);

//4. Что-то принимает (аргументы, данные). И что-то возвращает для дальнейшей работы.
string Metod4(int count, string text)
{
int i = 0;
string result = String.Empty;
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "asdf ");
Console.WriteLine(res);

//Цикл for
string Metod4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i<count; i++) // вначале ключевое слово, затем инициализация счётчика, после проверка условия и инкремент (увеличение счётчика).
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "asdf ");
Console.WriteLine(res);

// Цикл в цикле
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
Console.WriteLine();
}

// Работа с текстом

// string s = “qwerty”
//             012345
// s[3] // r

// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к» заменить большими «К», а большие «С» заменить на маленькие «с».

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replase(text, 'к','К');
Console.WriteLine(newText);

Console.WriteLine();  

newText = Replase(text, 'С','с');
Console.WriteLine(newText);

//Упорядочить массивы
// Алгоритм сортировки методом выбора, или Алгоритм сортировки методом минимакса или методом максимального

// Упорядочить элементы массива от минимального к максимальному

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

            for (int j = i+1; j < array.Length; j++)
            {
                if(array[j] < array[minPosition]) minPosition = j;
            }
                int temporary = array[i];
                array[i] = array[minPosition];
                array[minPosition] = temporary;
    }    

}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

// Упорядочить элементы массива от максимального к минимальному

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

            for (int j = i+1; j < array.Length; j++)
            {
                if(array[j] > array[maxPosition]) maxPosition = j;
            }
                int temporary = array[i];
                array[i] = array[maxPosition];
                array[maxPosition] = temporary;
    }    

}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);




