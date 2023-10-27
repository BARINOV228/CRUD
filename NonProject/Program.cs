using NonProject.DTO;
using NonProject.Model;
using NonProject.Service;
using static NonProject.Enum.ERole;

//EmployeeService.CreateEmployee(Employee.AddEmployee());
//EmployeeService.GetAllEmployee();
//EmployeeService.GetEmployeeById(1);

EmployeeDTO employeeDTO = new EmployeeDTO();
employeeDTO.Login = "ChangedLogin";
employeeDTO.Password = "ChangedPassword";
employeeDTO.Role = Role.Manager;

//EmployeeService.UpdateEmployee(1, employeeDTO);
//EmployeeService.DeleteEmployee(2);
EmployeeService.DeepDelete(3);


