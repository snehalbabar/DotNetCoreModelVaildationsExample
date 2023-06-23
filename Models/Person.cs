using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ModelValidationExample.Models
{
	public class Person
	{
		[Required]
		[Display(Name = "person Name")]
		[StringLength(10, MinimumLength = 2, ErrorMessage = "Not correct Name format")]
		public string? PersonName { get; set; }

		[Required]
		[EmailAddress(ErrorMessage = "Not Vaild email address")]
		public string? Email { get; set; }

		[Phone(ErrorMessage = "Invalid {0} Number Format")]
		public string? Phone { get; set; }

		public string? Password { get; set; }

		[Compare("Password", ErrorMessage ="Password not match")]
		public string? ComfirmPassword { get; set; }

		public double? salary { get; set; }

        public override string ToString()
        {
			return $"Person Objcet :" +
				$"{PersonName},{Email},{Phone},{Password},{ComfirmPassword},{salary}";
        }

    }
}

