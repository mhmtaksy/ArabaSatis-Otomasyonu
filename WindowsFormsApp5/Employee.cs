//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp5
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int employeeID { get; set; }
        public string employeeNameSurname { get; set; }
        public string employeePhone { get; set; }
        public string employeeTitle { get; set; }
        public string employeeMail { get; set; }
        public Nullable<int> employeeSalary { get; set; }
        public Nullable<int> carsID { get; set; }
    
        public virtual Car Car { get; set; }
    }
}