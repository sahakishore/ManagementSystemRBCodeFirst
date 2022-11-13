using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        //Navigation property, a Role have multiple Employees, one-to-many 
        public IList<Employee> Employees { get; set; }
    }

    //Employee Entity
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }


        //Navigation property, a Employee have only one role 
        public Roles Role { get; set; }


        //Navigation property, a Employee have only one EmployeeDetails, One-to-Zero-or-One
        public virtual EmployeeDetails EmployeeDetails { get; set; }


    }

    //EmployeeDetails Entity
    public class EmployeeDetails
    {
        //"EmployeeDetailsId" is PK in EmployeeDetails and FK in Employee table
        [ForeignKey("Employee")]
        public int EmployeeDetailsId { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        //Navigation property, a EmployeeDetails have only one Employee, one to one 
        public virtual Employee Employee { get; set; }

        /*
         Employee includes the EmployeeDetails navigation property and EmployeeDetails includes the Employee navigation property.
         With the one-to-zero-or-one relationship, a Employee can be saved without EmployeeDetails
         but the EmployeeDetails entity cannot be saved without the Employee entity.
         EF will throw an exception if you try to save the EmployeeDetails entity without the Employee entity.
         */

    }




    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
