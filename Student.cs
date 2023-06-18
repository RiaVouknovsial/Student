class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Year { get; set; }
    public int Age { get; set; }

    public Student(string name, string surname, int year, int age)
    {
        Name = name;
        Surname = surname;
        Year = year;
        Age = age;
    }
}
