﻿using System.ComponentModel.DataAnnotations;

namespace AccountDetailsWebApp.Model
{
    public class Register
    {
        [Key] 
        public int Id { get; set; }



        [Required(ErrorMessage = "First Name is required")]
        public string? FirstName { get; set; }



        [Required(ErrorMessage = "Last Name is required")]
        public string? LastName { get; set; }



        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }



        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        public string? Password { get; set; }



        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string? ConfirmPassword { get; set; }
   
    }
}
