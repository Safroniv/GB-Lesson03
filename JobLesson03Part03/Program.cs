//Написать программу, выводящую введённую пользователем строку в обратном порядке
//(olleH вместо Hello).
//string userString = Convert.ToString(Console.ReadLine());


string stringReverse = Console.ReadLine();
//разворот строки через reverce:
static string ReverseString(string stringToReverce)
{
    char[] charsOfString = stringToReverce.ToCharArray();
    Array.Reverse(charsOfString);
    return new String(charsOfString);
}
Console.WriteLine(Convert.ToString(ReverseString(stringReverse)));
Console.WriteLine();

//Разворот строки через for:

char[] chars = stringReverse.ToCharArray();

for (int i = chars.Length; i > 0; i--)
{
    Console.Write(chars[i-1]);
}
Console.ReadLine();