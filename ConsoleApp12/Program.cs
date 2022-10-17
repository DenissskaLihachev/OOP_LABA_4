using ConsoleApp12;

Person chel = new Person();

Console.Write("Введите имя: "); string name = Console.ReadLine();
Console.Write("Введите фамилию: "); string secondname = Console.ReadLine();
Console.Write("Введите пол: "); string gender = Console.ReadLine();
Console.Write("Введите возраст: "); int age = Convert.ToInt32(Console.ReadLine());

Person chel2 = new Person(name, secondname, gender, age);


ListQueue li = new ListQueue();
chel.print(li.get());
chel.print(li.get());

