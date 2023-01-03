using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.Model
{
    public class Session
    {
        [Key]
        public string Token { get; set; }

        [Required]
        public string Email { get; set; }

        public Session(string email)
        {
            Token = Guid.NewGuid().ToString();
            Email = email;
        }

        public Session() { }
    }
}
