using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AshkanCrm.Domain.Entities.Account
{
    public class User
    {
        public long UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string ImageName { get; set; }

        public string MobilePhone { get; set; }

        public Gender Gender { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsDelete { get; set; }


    }
    public enum Gender
    {
        [Display(Name = "عمومی")]
        General,
        [Display(Name = "مرد")]
        Male,
        [Display(Name = "زن")]
        Female,
    }
}
