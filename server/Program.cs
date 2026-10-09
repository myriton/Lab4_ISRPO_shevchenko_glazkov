using System;

Console.WriteLine("Привет");
Console.WriteLine("Шевченко В.Н.");
Console.WriteLine("ИСП-242");

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Меню:");
    Console.WriteLine("1 — Показать ФИО");
    Console.WriteLine("2 — Показать группу");
    Console.WriteLine("3 — Показать дату");
    Console.WriteLine("4 — Выход");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("ФИО: Шевченко В.Н.");
            break;
        case "2":
            Console.WriteLine("Группа: ИСП-242");
            break;
        case "3":
            Console.WriteLine("Дата: 09.10.26");
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Неверный выбор");
            break;
    }
}