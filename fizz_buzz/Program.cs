using System;

Console.Write("Введите количество игороков: "); 
int user = int.Parse(Console.ReadLine()); //количество игроков

Random random = new Random(); //для генерации случайных чисел

int i = 1; //
do
{

    int rnd_num = random.Next(100);//компьютер загадывает число от 1 до 99

    Console.Write("Компьютер загадал число: "+ rnd_num);

    string answer; //переменная для ответа

    Console.WriteLine("Ваш ответ: "); //вводим ответ
    answer = Console.ReadLine();

    //тело игры
    switch (rnd_num) //кейсы для сравнения ответа.
    {
        case 0: answer = "Fizz"; break;
        case 1: answer = "Buzz"; break;
        case 2: answer = "Fizz-Buzz"; break;
        default: answer = i.ToString(); break;
    }
    Console.Write(i + " " + answer); if (i % 3 == 0 && answer == "Fizz") Console.WriteLine("Верно");

    //проверка решения
    else if (i % 5 == 0 && answer == "Buzz") Console.WriteLine("Верно");
    else if (i % 3 == 0 && i % 5 == 0 && answer == "Fizz-Buzz") Console.WriteLine("Верно");
    else if (i % 3 != 0 && i % 5 != 0 && answer == i.ToString()) Console.WriteLine("Верно");
    else
    {
        Console.WriteLine("Неверно");
        user--;
    }
    if (user == 1)
    {
        Console.WriteLine("Выиграл игрок"); break;
    }
    i++;
} while (user != 1 && i <= 100); //цикл идет 100 раз и пока не останется один игрок