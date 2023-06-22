using System;
using System.ComponentModel.DataAnnotations;

namespace ModelValidationExample.Models
{
	public class Person
	{
		[Required]
		public string? PersonName { get; set; }

		[Required]
		public string? Email { get; set; }

		public  string? Phone { get; set; }

		public string? Password { get; set; }

		public string? ComfirmPassword { get; set; }

		public double? salary { get; set; }

        public override string ToString()
        {
			return $"Person Objcet :" +
				$"{PersonName},{Email},{Phone},{Password},{ComfirmPassword},{salary}";
        }

    }
}

