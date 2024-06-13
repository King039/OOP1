using _4;
// индексация 
Person p1 = new Person() { Name = "Иванов И.И." };
Person p2 = new Person() { Name = "Петров И.В." };
Person p3 = new Person() { Name = "Сидоров С.И." };

Person[] persons = new Person[3];
persons[0] = p1;
persons[1] = p2;
persons[2] = p3;

Company company = new Company { Personal = persons };

Console.WriteLine(company[0].Name);
Console.WriteLine(company[1].Name);
Console.WriteLine(company[2].Name);

User user = new User();
user["name"] = "Иванов И.И.";
user["email"] = "ivanov@mail.ru";
user["phone"] = "+7-911-834-52-51";

Console.WriteLine(user["name"] + " " + user["email"] + " " + user["phone"]);

Random random = new Random();
int[,] mas = new int[3, 4];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = random.Next(10, 100);
    }
}

Matrix matrix = new Matrix(mas);
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.WriteLine(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Massiv massive = new Massiv(10);

massive.Fill();
massive.Print();
massive.Mix();
massive.Print();

Console.WriteLine(massive.Different());