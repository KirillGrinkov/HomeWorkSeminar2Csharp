//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Clear();
Console.Write("Введите цифру дня недели: ");
string userImput = Console.ReadLine() ??"";
int weekDay = int.Parse(userImput);

if (weekDay < 1 || weekDay >7)
{
    Console.WriteLine("Такого дня недели нет! ");
}
else if (weekDay >= 1 && weekDay <= 5)
{
    Console.WriteLine("Будний день((");
}
else if (weekDay >= 6 && weekDay <= 7)
{
    Console.WriteLine("Выходной!!");
}