﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace ADO_codebase_3
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;





        public static void insertEmployee()
        {
            try
            {
                con = getconnection();
                Console.WriteLine("Enter the Employee name : ");
                string empname = Console.ReadLine();
                Console.WriteLine("Enter the Employee Salary : ");
                float empsal = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter the Employee type (C or P) : ");
                string emptype = Console.ReadLine();
                cmd = new SqlCommand("Employee_Management", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd = new SqlCommand("execute Employee_Management @empname,@empsal,@emptype", con);
                cmd.Parameters.Add(new SqlParameter("@empname", empname));
                cmd.Parameters.Add(new SqlParameter("@empsal", empsal));
                cmd.Parameters.Add(new SqlParameter("@emptype", emptype));




                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("rows effected :{0}", res);
                }
                else
                {
                    Console.WriteLine("No Row Effected");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DisplayAllEmployee()
        {
            con = getconnection();




            cmd = new SqlCommand("select * from Code_Employee", con);





            dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                Console.WriteLine("Emp no is : " + dr[0]);
                Console.WriteLine("Emp name is : " + dr[1]);
                Console.WriteLine("Emp Salary is : " + dr[2]);
                Console.WriteLine("Emp Type is : " + dr[3]);



            }
        }
        static void Main(string[] args)
        {
            insertEmployee();
            DisplayAllEmployee();
            Console.Read();
        }
        public static SqlConnection getconnection()
        {
            con = new SqlConnection(@"data source = POOLW42SLPC6855\SQLEXPRESS; Initial Catalog = EmployeeManagement; user id =sa; password =Temp1234");
            con.Open();
            return con;
        }
    }
}