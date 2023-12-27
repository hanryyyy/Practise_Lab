using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Exercise8
{
    public class Student
    {
        public int StudentsID { get; set; }
        public string StudentName { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
    }
    public class Car
    {
        public string name { get; set; }
        public int price { get; set; }
    }
    public class Users
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int salary { get; set; }
    }

    internal class Program
    {

        public static void Main(string[] args)
        {

            // Student collection
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentsID = 1, StudentName = "John", Location = "London", Date = DateTime.Parse("2001-04-01") },
                new Student() { StudentsID = 2, StudentName = "Jenny", Location = "New York", Date = DateTime.Parse("1997-12-11") },
                new Student() { StudentsID = 3, StudentName = "Andrew", Location = "Boston", Date = DateTime.Parse("1987-02-22") },
                new Student() { StudentsID = 4, StudentName = "Peter", Location = "Prague", Date = DateTime.Parse("1936-03-24") },
                new Student() { StudentsID = 5, StudentName = "Anna", Location = "Bratislava", Date = DateTime.Parse("1973-11-18") },
                new Student() { StudentsID = 6, StudentName = "Albert", Location = "Bratislava", Date = DateTime.Parse("1940-12-11") },
                new Student() { StudentsID = 7, StudentName = "Adam", Location = "Trnava", Date = DateTime.Parse("1983-12-01") },
                new Student() { StudentsID = 8, StudentName = "Robert", Location = "Bratislava", Date = DateTime.Parse("1935-05-15") },
                new Student() { StudentsID = 9, StudentName = "Robert", Location = "Prague", Date = DateTime.Parse("1998-03-14") },
            };
            IList<Car> carList = new List<Car>()
        {
            new Car() { name = "Audi ", price = 52642} ,
            new Car() { name = "Mercedes ", price = 57127} ,
            new Car() { name = "Skoda ", price = 9000} ,
            new Car() { name = "Volvo ", price = 29000} ,
            new Car() { name = "Bently ", price = 350000} ,
            new Car() { name = "Citoren ", price = 21000} ,
            new Car() { name = "Hummer ", price = 41400} ,
            new Car() { name = "Volkswagen ", price = 261000} ,
        };
            IList<Users> userlist = new List<Users>()
            {
                new Users(){ FirstName ="John", LastName="Doe",salary=1230},
                new Users(){ FirstName ="Lucy", LastName="Novak",salary=670},
                new Users(){ FirstName ="Ben", LastName="Walter",salary=2050},
                new Users(){ FirstName ="Robin", LastName="Brown",salary=2300},
                new Users(){ FirstName ="Amy", LastName="Doe",salary=1250},
                new Users(){ FirstName ="Joe", LastName="Draker",salary=1190},
                new Users(){ FirstName ="Janet", LastName="Dow",salary=980},
                new Users(){ FirstName ="Alber", LastName="Novak",salary=1930},
            };
            
            // Check student who lived in Bratislava
            Console.WriteLine(" Student who lived in Bratislava: ");
            var StudentLocation = studentList.Where(s => s.Location == "Bratislava");
            foreach (Student local in StudentLocation)
            {
                Console.Write(local.StudentName); Console.WriteLine();
            }
            
            // Check cars whose price is between 30000 and 100000                   
            Console.WriteLine("\n Cars whose price is between 30000 and 100000 are :");
            var CarPrice = from c in carList
                           where c.price >= 30000 && c.price <= 100000
                           select new { name = c.name };
            CarPrice.ToList().ForEach(c => Console.WriteLine(c.name));
            // Check  Sort ascending by last name and salary
            // Check users who have salary higher than 1500
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("\n Sort ascending by last name and salary: ");
            // Sort the usersList by last name and then by salary in ascending order
            var sortedUsers = userlist.OrderBy(user => user.LastName).ThenBy(user => user.salary).ToList();
            // Display the sorted list
            foreach (var user in sortedUsers)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName}, Salary: {user.salary}");
            }
            Console.WriteLine("\n Users who have salary higher than 1500");
            // Check user who have salary higher than 1500
            var userSalary = from u in userlist
                             where u.salary >= 1500
                             select new { u.FirstName, u.LastName };
            userSalary.ToList().ForEach(s => Console.WriteLine($"{s.FirstName}  {s.LastName} "));
            // the code that you want to measure comes here
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}




