/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Random rand = new Random();
string random;
string number = "";
string[] List = new string[5];
for(int i = 0; i < List.Length; i++)
{
    random = Convert.ToString(rand.Next(0, 10));
    List[i] = random;
    number += List[i];
}

System.Console.WriteLine($"Пятизначное число: {number}");
if(List[0] == List[4] && List[1] == List[3]) System.Console.WriteLine("Это число палиндром");
else System.Console.WriteLine("Это число не палиндром");

string InPut(string message)
{
    System.Console.WriteLine(message);
    string number = System.Console.ReadLine();
    return number;
}

string list = InPut("Enter a five-digit number: ");

void Palindrome()
{
    if(list[0] == list[4] && list[1] == list[3]) System.Console.WriteLine("Это число палиндром");
    else System.Console.WriteLine("Это число не палиндром");
}
Palindrome();
















