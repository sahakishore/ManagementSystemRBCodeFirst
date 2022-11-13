using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemRBCodeFirst
{
    //ManagementSystem Entities

    //Roles Entity
    public class Roles
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //Employee Entity
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }


        //Navigation property

    }

    //EmployeeDetails Entity
    public class EmployeeDetails
    {
        public int EmpDetailId { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        //Navigation property

    }




    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
