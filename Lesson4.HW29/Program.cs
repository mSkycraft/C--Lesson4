// Задача 29

Console.WriteLine("Задача 29");
Console.Write("Введите число элементов - ");
int a = int.Parse(Console.ReadLine());

void newMas(int a){
    List<int> mas = new List<int>{};
    for(int i = 0;i<a;i++){
        Console.Write("Введите число №" + (i+1) + " - ");
        mas.Add(int.Parse(Console.ReadLine()));
    }
    Console.Write("[ ");
    for(int i = 0;i<a-1;i++)
        Console.Write(mas[i]+", ");
    Console.Write(mas[a-1]+"]");
}

newMas(a);