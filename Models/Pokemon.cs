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
        public int Age { get; set; }

        [Display(Name = "Gender: M/F")]
        [StringLength(2)]
        public string Gender { get; set; }

        [Display(Name = "Hometown:")]
        public string Hometown { get; set; }

        [Display(Name = "Region:")]
        public string Region { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Dear trainer,\n please insert your password to keep your pokedex safe.")]
        [DataType(DataType.Password)]
        [StringLength(9)]
        public string Password { get; set; }

        [Display(Name = "Profile Picture")]
        public byte[]? Picture { get; set; }

    }

    public class Pokemon
    {
        [Key]
        [Display(Name = "ID:")]
        public Guid IdP { get; set; } 

        [Display(Name = "Pokémon:")]
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

        [Display(Name = "Pokemon Picture:")]
        public byte[]? PictureP { get; set; }

        [Display(Name = "Health Points:")]
        public double HP { get; set; }  

        [Display(Name = "Attack:")]
        public double Atk { get; set; }  

        [Display(Name = "Defence:")]
        public double Def { get; set; } 

        [Display(Name = "Sp.Atk:")]
        public double SpAtk { get; set; }

        [Display(Name = "Sp.Def:")]
        public double SpDef { get; set; }

        [Display(Name = "Speed:")]
        public double Speed { get; set; }

        [Display(Name = "Gender: M/F")]
        [MaxLength(2)]
        public string GenderP { get; set; }

    }
}
