/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

System.Console.Write("Введите число:   ");
string write = Console.ReadLine();
int Num = Convert.ToInt32(write);
int[] GetCube(int Num)
{
    int[] cubs = new int[Num];
    int number = 1;
    for (int i = 0; i < Num; i++)
    {
        cubs[i] = number * number * number;
        number++;
    }
    return cubs;
}
void PrintCubs(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{number} ^ 3 = ");
        System.Console.WriteLine(array[i]);
        number++;
    }
}
int[] CubeTable = GetCube(Num);
PrintCubs(CubeTable);
