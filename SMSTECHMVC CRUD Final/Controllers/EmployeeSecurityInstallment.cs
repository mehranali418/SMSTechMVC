//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeSecurityInstallment
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> DepositType { get; set; }
        public Nullable<System.DateTime> CurrentDate { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> EmployeePaymentID { get; set; }
        public Nullable<int> SalaryMonthID { get; set; }
        public Nullable<int> RefundableTypeID { get; set; }
    }
}
