﻿using System.ComponentModel.DataAnnotations;

namespace ShopCET46.Web.Models
{
    public class ChangePasswordViewModel
    {

        [Required]
        public string OldPassword { get; set; }



        [Required]
        public string NewPassword { get; set; }



        [Required]
        [Compare("NewPassword")]
        public string Confirm { get; set; }
    }
}
