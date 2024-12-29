namespace WebAPI4.Model
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public string? Designation { get; set; }

        public string? Department { get; set; }

        public string? Email { get; set; }
    }
}
