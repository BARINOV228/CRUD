using NonProject.Enum;
using NonProject.Interface;

namespace NonProject.Model
{
    public class Employee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public EStatus.Status Status { get; set; }
        public ERole.Role Role { get; set; }
        public string? CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public string? DeletedDate { get; set; }

        public static Employee AddEmployee()
        {
            return new Employee
            {
                Name = "Nurmuhammad",
                Surname = "Davletov",
                Email = "nurmuhammad1557@gmail.com",
                Login = "Login",
                Password = "Password",
                Status = EStatus.Status.Created,
                Role = ERole.Role.Programmer,
            };
        }
    }
}
