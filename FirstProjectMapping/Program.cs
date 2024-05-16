using FirstProjectMapping.Context;
using FirstProjectMapping.Entities;

namespace FirstProjectMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();
            #region insert
            //Department department1 = new Department() { Name = "Hr" };
            //Employee employee1 = new Employee()
            //{
            //    Name = "kyrillos",
            //    Age = 22,
            //    EmailAddress = "Kyrillos.maurice.com"
            //,
            //    DepartmentId = 10,
            //    salary = 50000,
            //    PhoneNumber = 01027436681
            //};
            //dbContext.Add(department1);
            //dbContext.Add(employee1);
            //dbContext.SaveChanges();
            #endregion

            #region Select
            var Employee = ( from E in dbContext.Employees
                            where E.Id == 1
                            select E).FirstOrDefault();
            Console.WriteLine(Employee?.Name?? "NA");
            #endregion

            #region update
            //Console.WriteLine(dbContext.Entry(Employee).State); // unchanged 
            //Employee.Name = " Eng.Kyrillos";
            //Console.WriteLine(dbContext.Entry(Employee).State); // modified 
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(Employee).State); // unchanged
            #endregion

            #region Delete
            //Console.WriteLine(dbContext.Entry(Employee).State); // unchanged 
            //dbContext.Employees.Remove(Employee);
            //Console.WriteLine(dbContext.Entry(Employee).State); // deleted 
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(Employee).State); // Detached  
            #endregion


        }
    }
}
