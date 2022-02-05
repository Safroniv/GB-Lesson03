//Урок 3 Задание 1
//Написать программу, выводящую элементы двумерного массива по диагонали.
//Ввод массива:
int[,] twoLinesMassive =
{
    { 1,2,3,4,5},
    { 6,7,8,9,10},
    { 11,12,13,14,15},
    { 16,17,18,19,20},
    { 21,22,23,24,25}
};
//Задаю значания элементов массива, чтобы было понятно какие именно элементы буду выводить
//Сначала вывожу весь массив
for (int i = 0; i < twoLinesMassive.GetLength(0); i++)
{
    for (int j = 0; j < twoLinesMassive.GetLength(1); j++)
    {
        Console.Write($"{twoLinesMassive[i, j]} ");
    }
    Console.WriteLine();
}
//Вывод через консоль отдельных элементов главной диагонали
Console.Write("\n" + twoLinesMassive[0,0] + " ");
Console.Write(twoLinesMassive[1,1] + " ");
Console.Write(twoLinesMassive[2,2] + " ");
Console.Write(twoLinesMassive[3,3] + " ");
Console.Write(twoLinesMassive[4,4] + " \n\n");

//Вывод элементов главной диагонали через цикл (нет ограничения для количества элементов):
for (int i = 0; i < twoLinesMassive.GetLength(0); i++)
{
    Console.Write(twoLinesMassive[i, i] + " ");

}
Console.WriteLine("\n");

//Вывод элементов второстепенной диагонали через цикл (нет ограничения для количества элементов):
for (int j = twoLinesMassive.GetLength(0)-1, i=0 ; j>=0 ; i++, j--)
{
    Console.Write(twoLinesMassive[i, j] + " ");

}
Console.WriteLine("\n");

// Вывод всех элементов массива по диагонали (сделан новый массив с последовательными числами):
int diagonal = 0;
int[,] massive = new int[3, 3];
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        massive[i, j] = diagonal + 1;
        Console.WriteLine($"{new string(' ', diagonal)}{massive[i, j]}");
        diagonal++;
    }
}
Console.ReadLine();

