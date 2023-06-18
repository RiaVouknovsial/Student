class StudentManager
{
    public List<Student> students;

    public StudentManager()
    {
        students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
        Console.WriteLine($"Студент '{student.Name}' успешно добавлен в базу данных.");
    }

    public void RemoveStudent(Student student)
    {
        if (students.Remove(student))
        {
            Console.WriteLine($"Студент '{student.Name}' успешно удален из базы данных.");
        }
        else
        {
            Console.WriteLine($"Студент '{student.Name}' не найден в базе данных.");
        }
    }

    public List<Student> GetStudentsByYear(int year)
    {
        List<Student> result = new List<Student>();

        foreach (Student student in students)
        {
            if (student.Year == year)
            {
                result.Add(student);
            }
        }

        if (result.Count == 0)
        {
            Console.WriteLine("Студенты с указанным номером курса не найдены");
        }

        return result;
    }

    public string GetOldestStudent()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("Список студентов пуст");
            return null;
        }

        Student oldestStudent = students[0];

        foreach (Student student in students)
        {
            if (student.Age > oldestStudent.Age)
            {
                oldestStudent = student;
            }
        }

        return oldestStudent.Name;
    }
}

