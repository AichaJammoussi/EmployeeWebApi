﻿using System.ComponentModel.DataAnnotations;

public class LoginModel
{
    [Required(ErrorMessage = "L'email est requis.")]
    [EmailAddress(ErrorMessage = "Format d'email invalide.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Le mot de passe est requis.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
