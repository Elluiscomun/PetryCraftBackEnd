using System.ComponentModel.DataAnnotations;

namespace Swagger5._0.Model
{
    public class User
    {
        [Key] // Especifica el atributo clave primaria
        public string Email_User { get; set; }
        public string Name_User { get; set; }
        public Gender Gender_User { get; set; }
        public string Password_User { get; set; }
        public int Id_Role { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }

}
