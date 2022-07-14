// Задача доп.

Console.WriteLine("Задача Доп");
Console.Write("Введите слово - ");
string str = Console.ReadLine();

void doublechar (string str){
    bool flag = false;
    for(int i=0;i<(str.Length-1);i++)
        if(str[i]==str[i+1])
            flag = true;
    Console.WriteLine(flag);
}

doublechar(str);