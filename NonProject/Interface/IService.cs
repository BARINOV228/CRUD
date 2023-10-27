using NonProject.DTO;
using NonProject.Model;

namespace NonProject.Interface
{
    public interface IService
    {
        public static void CreateEmployee(Employee employee) { }
        public static void UpdateEmployee(int id, EmployeeDTO e) { }
        public static void DeleteEmployee(int id) { }
        public static void DeepDelete(int id) { }
        public static void GetAllEmployee() { }
        public static void GetEmployeeById(int id) { }

    }
}
