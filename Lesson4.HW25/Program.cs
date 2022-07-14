// Задача 25

Console.WriteLine("Задача 25");
Console.Write("Введите число 1 - ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2 - ");
int b = int.Parse(Console.ReadLine());

void Pow(int a,int b){
    int step = a;
    for(int i=1;i<b;i++)
        step = step * a;
    Console.WriteLine(a+" в степени "+b + " = "+ step);
}


Pow(a,b);