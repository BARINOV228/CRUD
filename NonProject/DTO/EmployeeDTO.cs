﻿using static NonProject.Enum.ERole;

namespace NonProject.DTO
{
    public class EmployeeDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
