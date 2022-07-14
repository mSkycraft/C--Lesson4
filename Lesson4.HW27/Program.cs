// Задача 27
Console.WriteLine("Задача 27");
Console.Write("Введите число - ");
int a = int.Parse(Console.ReadLine());

void sumNum(int a){
    int buf = a;
    int sum = 0;

    for(;(buf%10!=0)&&(((int)buf/10)!=0);)
    {
        sum = sum + buf%10;
        buf = (int) buf/10;
    }
    sum = sum + buf;
    Console.WriteLine("Сумма = "+sum);
}

sumNum(a);