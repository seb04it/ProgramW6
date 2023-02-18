
using ProgramW6;

Employee employee1 = new Employee("Seba", "W.", "18");
Employee employee2 = new Employee("Szymon", "B.", "18");
Employee employee3 = new Employee("Michał", "K.", "17");

employee1.AddScore(2);
employee1.AddScore(6);
employee1.AddScore(7);
employee1.AddScore(4);
employee1.AddScore(7);

employee2.AddScore(1);
employee2.AddScore(7);
employee2.AddScore(5);
employee2.AddScore(8);
employee2.AddScore(9);

employee3.AddScore(7);
employee3.AddScore(4);
employee3.AddScore(9);
employee3.AddScore(7);
employee3.AddScore(7);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int highScore = -1;
Employee employeeWithHighScore = null;

foreach (var employee in employees)
{
    if (employee.Score > highScore)
    {
        highScore = employee.Score;
        employeeWithHighScore = employee;
    }
}

Console.WriteLine
(
    "Pracownik z najlepszym wynikiem to: " +
    employeeWithHighScore.Name +
    " " + employeeWithHighScore.Surname +
    " Lat: " + employeeWithHighScore.Age +
    "\t" + "Z wynikiem: " +
    employeeWithHighScore.Score
);