using System.ComponentModel.DataAnnotations;

namespace EmployeeWebApi.Models
{


    public class RegisterModel
    {
        [Required(ErrorMessage = "L'email est requis.")]
        [EmailAddress(ErrorMessage = "Format d'email invalide.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le nom d'utilisateur est requis.")]
        [MinLength(3, ErrorMessage = "Le nom d'utilisateur doit contenir au moins 3 caractères.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Le prénom est requis.")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ\s\-]+$", ErrorMessage = "Le prénom ne doit contenir que des lettres.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Le nom est requis.")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ\s\-]+$", ErrorMessage = "Le nom ne doit contenir que des lettres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Le numéro de téléphone est requis.")]
        [Phone(ErrorMessage = "Format du numéro de téléphone invalide.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Le mot de passe doit contenir au moins 8 caractères.")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$",
            ErrorMessage = "Le mot de passe doit contenir au moins une lettre, un chiffre et un caractère spécial.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Veuillez confirmer votre mot de passe.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Les mots de passe ne correspondent pas.")]
        public string ConfirmPassword { get; set; }
    }

}