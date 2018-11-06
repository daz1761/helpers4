using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helpers4.Models
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
        // I think we use these in Umbraco which explains things now with the Attributes overriding model properties
    }

    public class EmployeeMetadata
    {
        // hyperlink
        [DataType(DataType.Url)]
        public string PersonalWebSite { get; set; }

        // this will be NULL when it comes to Model binding
        [ReadOnly(true)]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        //[DisplayAttribute(Name = "Full Name")]
        //[Display(Name = "Full Name")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? HireDate { get; set; }

        [DisplayFormat(NullDisplayText ="Gender Not Specified")]
        public string Gender { get; set; }

        // hide column if set to false
        [ScaffoldColumn(true)]
        [HiddenInput(DisplayValue = false)]
        public int? Id { get; set; }

        [ScaffoldColumn(true)]
        [DataType(DataType.Currency)]
        public int? Salary { get; set; }
    }

}