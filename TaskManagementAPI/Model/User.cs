using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Model
{
    public class User
    {
        [Key]
        public string Uid { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public User(string name, string email, string password)
        {
            Uid = Guid.NewGuid().ToString();
            Name = name;
            Email = email;
            Password = password;
        }

        public User() { }

        public bool validatePassword(string pwd)
        {
            return (pwd == Password) ? true : false;
        }
    }
}
