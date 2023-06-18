class Menu
{
    StudentManager studentManager = new StudentManager();
    bool exit = false;

    public void Start()
    {
        while (!exit)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить студента");
            Console.WriteLine("2. Удалить студента");
            Console.WriteLine("3. Просмотреть список студентов на определенном курсе");
            Console.WriteLine("4. Получить информацию о самом старшем студенте");
            Console.WriteLine("5. Выйти");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    RemoveStudent();
                    break;
                case "3":
                    GetStudentsByYear();
                    break;
                case "4":
                    GetOldestStudent();
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Выход из программы.");
                    break;
                default:
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                    break;
            }

            Console.WriteLine();
        }
    }

    void AddStudent()
    {
        Console.WriteLine("Введите имя студента:");
        string name = Console.ReadLine();

        Console.WriteLine("Введите фамилию студента:");
        string surname = Console.ReadLine();

        Console.WriteLine("Введите номер курса студента:");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите возраст студента:");
        int age = int.Parse(Console.ReadLine());

        Student student = new Student(name, surname, year, age);
        studentManager.AddStudent(student);
    }

    void RemoveStudent()
    {
        Console.WriteLine("Введите имя студента, которого хотите удалить:");
        string name = Console.ReadLine();

        Console.WriteLine("Введите фамилию студента, которого хотите удалить:");
        string surname = Console.ReadLine();

        Student student = studentManager.students.Find(s => s.Name == name && s.Surname == surname);

        if (student != null)
        {
            studentManager.RemoveStudent(student);
        }
        else
        {
            Console.WriteLine("Студент не найден.");
        }
    }

    void GetStudentsByYear()
    {
        Console.WriteLine("Введите номер курса, чтобы получить список студентов на этом курсе:");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine($"Студенты на {year} курсе:");

        List<Student> students = studentManager.GetStudentsByYear(year);

        foreach (Student student in students)
        {
            Console.WriteLine($"Имя: {student.Name}, Фамилия: {student.Surname}, Курс: {student.Year}, Возраст: {student.Age}");
        }
    }

    void GetOldestStudent()
    {
        string oldestStudentName = studentManager.GetOldestStudent();

        if (oldestStudentName != null)
        {
            Console.WriteLine($"Самый старший студент: {oldestStudentName}");
        }
        else
        {
            Console.WriteLine("Список студентов пуст");
        }
    }
}

