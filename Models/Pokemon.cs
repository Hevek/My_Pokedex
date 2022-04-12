using System.ComponentModel.DataAnnotations;

namespace Poke.Models
{
    public class Trainer
    {
        [Key]
        [Display(Name = "ID:")]
        public Guid IdT { get; set; }

        [Required(ErrorMessage = "Insert your name!")]
        [Display(Name = "Name:")]
        public string Name { get; set; }

        [Display(Name = "Age:")]
        [MinLength(14)]
        public int Age { get; set; }

        [Display(Name = "Gender:")]
        [StringLength(2)]
        public string Gender { get; set; }

        [Display(Name = "Hometown:")]
        public string Hometown { get; set; }

        [Display(Name = "Region:")]
        public string Region { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Dear trainer, please insert your password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }   

    }

    public class Pokemon
    {
        [Key]
        [Display(Name = "ID:")]
        public Guid IdP { get; set; } 

        [Display(Name = "Pókemon:")]
        [Required]
        public string PokeN { get; set; }

        [Display(Name = "Type:")]
        public string TypeP { get; set; }

        [Display(Name = "Height:")]
        public double Height { get; set; }

        [Display(Name = "Weight:")]
        public double Weight { get; set; }

        [Display(Name = "Ability 1:")]
        public string Ability { get; set; }

        [Display(Name = "Picture")]
        public byte[]? Picture { get; set; }

        [Display(Name = "HP:")]
        public double HP { get; set; }  

        [Display(Name = "Attack:")]
        public double Atk { get; set; }  

        [Display(Name = "Defence:")]
        public double Def { get; set; } 

        [Display(Name = "Sp. Atk:")]
        public double SpAtk { get; set; }

        [Display(Name = "Sp. Def:")]
        public double SpDef { get; set; }

        [Display(Name = "Speed:")]
        public double Speed { get; set; }

        [Display(Name = "Gender:")]
        [MaxLength(2)]
        public string GenderP { get; set; }

    }
}
