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
