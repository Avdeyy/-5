// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using практическая_5;
void GetAScholarship(StudentOfISIT stud)
{
    if (DateTime.Now.Day == 14 && !stud.Scholarshipwarning)
    {
        stud.Check += stud.ScholarshipAmount;
        stud.Scholarshipwarning = true;
    }
}

void SpendAScholarship(int money, string itemOfExpenditure, StudentOfISIT stud)
{
    if (stud.Warning)
        Console.WriteLine("Осталось мало денег!");
    else if (stud.Check - money < 0)
        Console.WriteLine("Денег не хватит!");
    else
    {
        stud.Check -= money;
    }
}
Console.Write("Введите размер вашей стипендии: ");

int mny = Convert.ToInt32(Console.ReadLine());
StudentOfISIT stud = new StudentOfISIT { ScholarshipAmount = mny, Scholarshipwarning = false, };
while (true)
{
    Console.Clear();
    Console.WriteLine("1. Задать имя студенту\n" +
                    "2. Ввести информацию о студенте\n" +
                    "3. Получить деньги\n" +
                    "4. Потратить деньги\n" +
                    "5. Узнать, сколько денег на счету");

    Console.Write("Выберите номер операции: ");
    string? a = Console.ReadLine();

    switch (a)
    {
        case "1":
            Console.Clear();
            Console.Write("Введите имя студента: ");
            try
            {
                stud.Name = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Имя уже задано");
            }
            Console.Write("Введите специальность студента: ");
            try
            {
                stud.Speciality = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Специальность уже задана\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
            }
            break;

        case "2":
            if (!string.IsNullOrEmpty(stud.Name) && !string.IsNullOrEmpty(stud.Speciality))
            {
                Console.Clear();
                Console.WriteLine($"Имя пользователя: {stud.Name}");
                Console.WriteLine($"Специальность пользователя: {stud.Speciality}");
                Console.WriteLine($"Размер ежемесячной стипендии пользователя: {stud.ScholarshipAmount}");
                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы не зарегестрировались");
                Console.ReadKey();
            }
            break;

        case "3":
            if (!string.IsNullOrEmpty(stud.Name) && !string.IsNullOrEmpty(stud.Speciality))
            {
                Console.Clear();
                GetAScholarship(stud);
                Console.WriteLine($"У вас на счету: {stud.Check} руб");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы не зарегестрировались");
                Console.ReadKey();
            }
            break;

        case "4":
            if (!string.IsNullOrEmpty(stud.Name) && !string.IsNullOrEmpty(stud.Speciality))
            {
                Console.Clear();
                Console.Write("Сколько хотите потратить: ");
                int money = Convert.ToInt32(Console.ReadLine());

                Console.Write("На что?: ");
                string itemOfExpenditure = Console.ReadLine()!;

                SpendAScholarship(money, itemOfExpenditure, stud);
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы не зарегестрировались");
                Console.ReadKey();
            }
            break;

        case "5":
            if (!string.IsNullOrEmpty(stud.Name) && !string.IsNullOrEmpty(stud.Speciality))
            {
                Console.Clear();
                Console.WriteLine($"У вас на счету: {stud.Check} руб");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы не зарегестрировались");
                Console.ReadKey();
            }
            break;
    }
}