﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThreading
{
    //Employee Model
    public class EmployeeDetails
    {
        
        public int id { get; set; }
        public string EmployeeName { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public DateTime StartDate { get; set; }
    }
}
