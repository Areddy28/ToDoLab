using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoLab.Models
{
    public class Assignment
    {
        //This is the model for our many to many relationship
        //Each employeee can have multiple assignments 
        //Each To Do can have multiple employees
        //Each row in this table links an assignment to an employee 
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ToDoId { get; set; }
        public Employee Employee { get; set; }
        public ToDo ToDo { get; set; }
    }
}
