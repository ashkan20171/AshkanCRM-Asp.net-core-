using AshkanCRM.Domain.Entities.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AshkanCrm.Domain.ViewModels.User
{
    public class AddMarketerViewModel
    {

        [Display(Name = "نام کاربری")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از بلاک {1} باشد")]
        public string UserName { get; set; }

        [Display(Name = "کلمه عبور")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از بلاک {1} باشد")]
        public string Password { get; set; }

        [Display(Name = "نام")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از بلاک {1} باشد")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از بلاک {1} باشد")]
        public string LastName { get; set; }

        [Display(Name = "ایمیل")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از بلاک {1} باشد")]
        public string Email { get; set; }


        [Display(Name = "شماره موبایل")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از بلاک {1} باشد")]
        public string MobilePhone { get; set; }


        [Display(Name = "نام معرف")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از بلاک {1} باشد")]
        public string IntroduceName { get; set; }


        [Display(Name = "رشته تحصیلی")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از بلاک {1} باشد")]
        public string FieldStudy { get; set; }

        public int Age { get; set; }

        [Display(Name = "کد ملی")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از بلاک {1} باشد")]
        public string IrCode { get; set; }

        public Education Education { get; set; }
    }
    public enum AddMarketerResult
    {
        Succes,
        Fail,
        Success
    }
}
