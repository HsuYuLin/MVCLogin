using MVCLogin.ValidateAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLogin.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [NoIs("skilltree,demo,twMVC",ErrorMessage = "帳號不可包含skilltree,demo,twMVC字串")]
        [EmailAddress(ErrorMessage = "請輸入Email格式！")]
        [Display(Name = "帳號")]
        public string Account { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "{0} 的長度至少必須為 {2} 個字元。", MinimumLength = 4)]
        [Display(Name = "密碼")]
        //[MaxLength(20), MinLength(4)]
        public string Password { get; set; }

        public string Message { get; set; }
    }
}