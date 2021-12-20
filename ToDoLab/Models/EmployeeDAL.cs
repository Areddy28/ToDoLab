using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoLab.Models
{
    public class EmployeeDAL
    {
        //Get CRUD Actions working
        //Once we get this working in employee we can then reuse most of this code for ToDo
        public List<Employee> GetEmployees()
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from employee";
                connect.Open();
                List<Employee> employees = connect.Query<Employee>(sql).ToList();
                connect.Close();
                return employees; 
            }
        }

        public Employee GetEmployee(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from employee where id=" +id;
                connect.Open();
               Employee employees = connect.Query<Employee>(sql).ToList().First();
                connect.Close();
                return employees;
            }

        }

        public void AddEmployee(Employee e)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {

            string sql = $"insert into employeee values(0, {e.Name}, {e.HoursAvailable}, {e.Title})";
            connect.Open();
            connect.Query<Employee>(sql);
            connect.Close();
            }

        }

        public void DeleteEmployee(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "delete from Employee where Id=" + id;
                string sql1 = "delete from Assignments where employeeId=" + id;
                connect.Open();
                connect.Query<Assignment>(sql1); 
                //Query always returns a list regardless of how many movies we want.
                //Even if our query is mean to return 1 movie, we still need to pull it out of a list of count 1
                connect.Query<Employee>(sql);
                connect.Close();


            }

        }

        public void UpdateEmployee(Employee e)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"update employee set `name`='{e.Name}', hoursavailable= {e.HoursAvailable}, title='{e.Title}' where id=" + e.Id;
                connect.Open();
                connect.Query<Employee>(sql);
                connect.Close();
            }
        }
    }
}
