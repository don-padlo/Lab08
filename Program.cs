int lessonNumber = 5;
int totalLessons = 1;

while (lessonNumber >= totalLessons)
{
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--;
}
Console.WriteLine("Пары закончились");

int sum = 0;
int count = 0;
int mx_grade = 0;

Console.WriteLine("Вводите оценки, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine()!);
while (grade != -1)
{
    sum += grade;
    count++;
    if (mx_grade < grade)
    {
        mx_grade = grade;
    }
    grade = int.Parse(Console.ReadLine()!);
}
if (count > 0)
{
    Console.WriteLine($"Средний балл: {(double)sum / count}");
    Console.WriteLine($"Максимальная оценка: {mx_grade}");
}
else
{
    Console.WriteLine("Оценок не было введено");
}


string correctPassword = "qwerty123";
int count_t = 0;

while (true)
{
    Console.WriteLine("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine($"Доступ разрешён. Неверных попыток входа: {count_t}"); break;
    }
    Console.WriteLine("Неправильно, попробуй ещё раз"); count_t++;
}

Console.WriteLine();
//A
int n = 6; int count_c = 0;
while (count_c != 10)
{
    count_c++;
    Console.WriteLine($"{count_c}*{n}={count_c * n}");
}

Console.WriteLine();
//Б
string name = "";
int count_q = 0;
while (name != "конец")
{
    name = Console.ReadLine(); ++count_q;
}
Console.WriteLine($"Имён введено: {count_q - 1}");

Console.WriteLine();
//3
int b = 6; int count_l = 0;
while (count_l != b)
{
    count_l++;
    Console.WriteLine($"{count_l}*{count_l}={count_l * count_l}");
}

//7
Console.WriteLine();
Console.WriteLine("Введите температуру за неделю:");
int temp = 0; int count_e = 0;

while (count_e != 7)
{
    temp += int.Parse(Console.ReadLine()!); count_e++;
}
Console.WriteLine($"Температура за неделю:{(double)temp / 7}");


//доп
int pin = 1234;
Console.WriteLine("Введите ПИН");
int pin2 = int.Parse(Console.ReadLine());
int count_g = 0;

    while (count_g != 2)
    {
        if (pin2 != pin)
        {
            Console.WriteLine($"Неверный ПИН. Осталось попыток: {2 - count_g}");
            pin2 = int.Parse(Console.ReadLine()!); count_g++;
        }
        else
        {
            Console.WriteLine("Верный пин"); break;
        }
    }