﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodShopOnline.Models
{
    public class RegisterModel
    {
        [Key]
        public long ID { get; set; }

        [Display(Name = "Tên tài khoản *")]
        [Required(ErrorMessage ="Yêu cầu tên đăng nhập")]
        public string UserName { set; get; }

        [Display(Name = "Mật Khẩu *")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z]).{8,}$",
            ErrorMessage = "Mật khẩu ít nhất 8 ký tự, phải bao gồm ký tự hoa, ký tự thường và số")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        public string Password { set; get; }

        [Display(Name = "Nhập lại mật khẩu *")]
        [Compare("Password", ErrorMessage ="Xác nhận mật khẩu không đúng")]
        public string ConfirmPassword { set; get; }

        [Display(Name = "Họ và Tên *")]
        [Required(ErrorMessage = "Yêu cầu nhập Họ Tên")]
        public string Name { set; get; }

        [Display(Name = "Địa chỉ *")]
        [Required(ErrorMessage = "Yêu cầu nhập Địa chỉ")]
        public string Address { set; get; }

        [Display(Name = " Email *")]
        [Required(ErrorMessage = "Yêu cầu nhập Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { set; get; }
    }
}