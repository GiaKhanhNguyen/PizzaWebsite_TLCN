﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodShopOnline.Models
{
    public class ChangePassword
    {
        [Key]
        [Display(Name = "Mật khẩu hiện tại")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu hiện tại")]
        public string OldPassword { get; set; }

        [RegularExpression(@"^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z]).{8,}$",
            ErrorMessage = "Mật khẩu ít nhất 8 ký tự, phải bao gồm ký tự hoa, ký tự thường và số")]
        [Display(Name = "Mật khẩu mới")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu mới")]
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "Xác nhận mật khẩu không đúng")]
        [Display(Name = "Xác nhận mật khẩu")]
        public string ConfirmPassword { get; set; }

    }
}