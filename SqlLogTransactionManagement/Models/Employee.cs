//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlLogTransactionManagement.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        public int Col1 { get; set; }
        public Nullable<decimal> Col2 { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Col3 { get; set; }

    }
}
