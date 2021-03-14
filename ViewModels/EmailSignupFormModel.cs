using System;
using System.ComponentModel.DataAnnotations;

public class EmailSignupFormModel
{
  [Required]
  public string Email { get; set; }
}