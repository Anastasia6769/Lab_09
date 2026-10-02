//от while к for
int totalExercises = 8;
for(int number = totalExercises;number>=1;number--)
{
    Console.WriteLine($"Упражнение {number}");
}
Console.WriteLine("Домашнее задание готова");
//шаг цикла
for (int room = 5; room <= 50; room += 5)
{
    Console.WriteLine($"Кабинет{room}");
}
//вложенные  циклы
int totalWeeks = 3;
for (int week = 1; week <= totalWeeks; week++)
{
    for (int day = 1; day <= 5; day++)
    {
        Console.WriteLine($"Неделя{week}, день{day}");
    }
    Console.WriteLine("^_^");
}
//break и continue
int count = 0;
for (int ticket = 1; ticket <= 30; ticket++)
{
    if (ticket == 4 || ticket == 12 || ticket == 19)
    {
        count++;
        continue;
    }
    Console.WriteLine($"Пропущенные билеты:{count}");
    Console.WriteLine($"Первый доступный билет:{ticket}");
    break;
}
//Знакомство с бесконечным for
// for (; ; )
// {
//     Console.Write("Введите код группы(для выхода - 'выход'):");
//     string groupCode = Console.ReadLine();

//     if (groupCode == "выход")
//     {
//         break;
//     }

//     Console.WriteLine($"Записан код группы:{groupCode}");
// }
// Console.WriteLine("Работа с журналом завершена");
//Самостоятельные задания ★
//Задача Б
for (int i = 100; i >= 0; i -= 10)
{
    Console.WriteLine(i);
}
//Задача В
for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        Console.Write(i * j + " ");
    }
    Console.WriteLine();
}
// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
// if (string.IsNullOrEmpty(surname)) { 
// Console.WriteLine("Фамилия не введена. Завершение работы."); 
// return; 
// } 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
// var assigned = Enumerable.Range(1, 10) 
// .OrderBy(_ => rnd.Next()) 
// .Take(2) 
// .OrderBy(x => x) 
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}"); 
//Индивидуальные задания 
//Вариант 3
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.WriteLine($"{i} → {i * i * i}");
//Вариант 6
for (int i = 1; i <= 30; i++) {
    if (i % 4 == 0) continue;
    Console.WriteLine(i);
    }