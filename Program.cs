int lessonNumber = 5;
int totalLessons = 1;

while (lessonNumber >= totalLessons){
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
if (count>0){
    Console.WriteLine($"Средний балл: {(double)sum/count}");
    Console.WriteLine($"Максимальная оценка: {mx_grade}");
} else {
    Console.WriteLine("Оценок не было введено");
}


string correctPassword = "qwerty123";
int count_t = 0;

while (true){
    Console.WriteLine("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword ){
        Console.WriteLine($"Доступ разрешён. Неверных попыток входа: {count_t}");break;
    }
    Console.WriteLine("Неправильно, попробуй ещё раз");count_t++;
}