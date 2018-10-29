using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Democracy.Models
{
    public class User
    {
        [Key]
        public int UserId{ get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Display(Name = "Email")]
        [StringLength(100, ErrorMessage = "The field {0} can contain maximum {1} and minimum {2} characters", MinimumLength = 7)]
        [DataType(DataType.EmailAddress)]
        [Index("UserNameIndex", IsUnique = true)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Display(Name = "First name")]
        [StringLength(50, ErrorMessage = "The field {0} can contain maximum {1} and minimum {2} characters", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Display(Name = "Last name")]
        [StringLength(50, ErrorMessage = "The field {0} can contain maximum {1} and minimum {2} characters", MinimumLength = 2)]
        public string LastName { get; set; }

        [StringLength(20, ErrorMessage = "The field {0} can contain maximum {1} and minimum {2} characters", MinimumLength = 7)]
        [Required(ErrorMessage = "The field {0} is required")]
        public string Phone { get; set; }

        [StringLength(100, ErrorMessage = "The field {0} can contain maximum {1} and minimum {2} characters", MinimumLength = 5)]
        [Required(ErrorMessage = "The field {0} is required")]
        public string Address { get; set; }

        public string Grade { get; set; }

        public string Group { get; set; }

        [StringLength(200, ErrorMessage = "The field {0} can contain maximum {1} and minimum {2} characters", MinimumLength = 5)]
        [DataType(DataType.ImageUrl)]
        public string Photo { get; set; }
    }
}