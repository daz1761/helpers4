using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Helpers4.Models
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
        // I think we use these in Umbraco which explains things now with the Attributes overriding model properties
    }

    public class EmployeeMetadata
    {
        //[DisplayAttribute(Name = "Full Name")]
        //[Display(Name = "Full Name")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? HireDate { get; set; }

        [DisplayFormat(NullDisplayText ="Gender Not Specified - maybe this is a transgender cunt")]
        public string Gender { get; set; }

        [ScaffoldColumn(false)]
        public int? Id { get; set; }

        [ScaffoldColumn(false)]
        public int? Salary { get; set; }
    }

}