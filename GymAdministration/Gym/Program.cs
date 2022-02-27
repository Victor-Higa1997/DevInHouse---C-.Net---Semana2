
using GymAdministration.Core;

List<Student> students = new List<Student>();

students.Add(new Student(1, "Victor", "1 obs", new DateTime(26 / 02 / 2022)));
students.Add(new Student(2, "Fulano", "2 obs", new DateTime(27 / 02 / 2022)));
students.Add(new Student(3, "Beltrano", "3 obs", new DateTime(28 / 02 / 2022)));
students.Add(new Student(4, "Ciclano", "4 obs", new DateTime(21 / 03 / 2022)));
students.Add(new Student(5, "Deltrano", "5 obs", new DateTime(29 / 04 / 2022)));
students.Add(new Student(6, "Zé", "6 obs", new DateTime(26 / 05 / 2022)));
students.Add(new Student(7, "João", "7 obs", new DateTime(26 / 06 / 2022)));
students.Add(new Student(8, "Maria", "8 obs", new DateTime(26 / 07 / 2022)));
students.Add(new Student(9, "Fulana", "9 obs", new DateTime(26 / 08 / 2022)));
students.Add(new Student(10, "Ciclana", "10 obs", new DateTime(26 / 09 / 2022)));

Employee employee1 = new Employee("CT");


Console.WriteLine("---------------------------- GYM ----------------------------");
foreach (Student student in students)
{
    ActivityClass activityClass = new ActivityClass(student.Name, employee1.Name, DateTime.Now);
    Console.WriteLine($"Aluno: {activityClass.Name}, Gym: {activityClass.Description}, Inicio: {activityClass.StartedActivity}");
}


List<Equipament> equipments = new List<Equipament>();
equipments.Add(new Equipament(1, "Supino", "Maquina p/ peito", new DateTime(01 / 01 / 2022)));
equipments.Add(new Equipament(2, "Extensora", "Maquina p/ perna", new DateTime(01 / 01 / 2022)));
equipments.Add(new Equipament(3, "Flexora", "Maquina p/ perna", new DateTime(01 / 01 / 2022)));
equipments.Add(new Equipament(4, "Abdutor", "Maquina p/ perna", new DateTime(01 / 01 / 2022)));
equipments.Add(new Equipament(5, "Supino Inclinado", "Maquina p/ peito", new DateTime(01 / 01 / 2022)));
equipments.Add(new Equipament(6, "Supino Declinado", "Maquina p/ peito", new DateTime(01 / 01 / 2022)));
equipments.Add(new Equipament(7, "Crossover", "Maquina p/ peito", new DateTime(01 / 01 / 2022)));
equipments.Add(new Equipament(8, "Esteira", "Maquina Aerobica", new DateTime(01 / 01 / 2022)));
equipments.Add(new Equipament(9, "Bike", "Maquina Aerobica", new DateTime(01 / 01 / 2022)));
equipments.Add(new Equipament(10, "Pulley", "Maquina p/ costas", new DateTime(01 / 01 / 2022)));

Console.WriteLine("---------------------------- Equipamentos ----------------------------");

foreach (var equipment in equipments)
{
    Console.WriteLine($"Equipamento: {equipment.Name}, Utilização: {equipment.Description}, " +
        $"Data de aquisição: {equipment.AcquiredDate}");
}

Console.WriteLine("---------------------------- Employees ----------------------------");

List<Employee> employees = new List<Employee>();
employees.Add(new Employee("CT"));
employees.Add(new Employee("Gym2"));
employees.Add(new Employee("Gym3"));
employees.Add(new Employee("Gym4"));
employees.Add(new Employee("Gym5"));

foreach (Employee employee in employees)
{
    Console.WriteLine($"Academias: {employee.Name}, Status: {employee.Status}");
}

Console.ReadKey(); 