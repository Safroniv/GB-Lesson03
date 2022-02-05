//Урок 3 Задание 2
//Написать программу «Телефонный справочник»: 
//создать двумерный массив 5х2, хранящий список телефонных контактов:
//первый элемент хранит имя контакта, второй — номер телефона/email.

//создание массива можно так:
Console.WriteLine("Телефоный справлчник Вариант 1:");
Console.WriteLine("Имя:  Номер телефона (или E-mail):");
string[,] phoneBook =
{
    {"Vasia", "+1(234)567-89-01"},
    {"Kolia", "+2(345)678-90-12"},
    {"Anna ", "Anna@kokoko.re"},
    {"Vera ", "+4(567)890-12-34"},
    {"Tolya", "+5(678)901-23-45"},
};

//Вывод телефонного справочника #1
for (int i = 0; i < phoneBook.GetLength(0); i++)
{
    for (int j = 0; j < phoneBook.GetLength(1); j++)
    {
        Console.Write($"{phoneBook[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Телефоный справлчник Вариант 2:");
Console.WriteLine("Имя:  Номер телефона:");

//Второй вариант вывода сравочника:
string[,] phoneBook2 = new string[5, 2];
phoneBook2[0, 0] = "Kolya";
phoneBook2[0, 1] = "+1(234)567-89-01";
phoneBook2[1, 0] = "Vasya";
phoneBook2[1, 1] = "+2(345)678-90-12";
phoneBook2[2, 0] = "Anna ";
phoneBook2[2, 1] = "+3(456)789-01-23";
phoneBook2[3, 0] = "Vera ";
phoneBook2[3, 1] = "Verunchik@GBmail.else";
phoneBook2[4, 0] = "Tolya";
phoneBook2[4, 1] = "+5(678)901-23-45";

//Вывод телефонного справочника #2:
    for (int i = 0; i < phoneBook2.GetLength(0); i++)
{
    for (int j = 0; j < phoneBook2.GetLength(1); j++)
    {
        Console.Write($"{phoneBook2[i, j]} ");
    }
    Console.WriteLine();
}
Console.ReadLine();