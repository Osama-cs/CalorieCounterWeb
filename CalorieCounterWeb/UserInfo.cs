using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace CalorieCounterWeb
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required, StringLength(50, ErrorMessage = "Name is too long, enter a new name")]
        public string? Name { get; set; }

        [Required, StringLength(50, ErrorMessage = "Username is too long, enter a new username")]
        public string? UserName { get; set; }

        [Required, EmailAddress]
        public string? Email { get; set; }

        [Required, StringLength(100, ErrorMessage = "Password is too long, enter a new password"), PasswordPropertyText]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "Password must match")]
		public string? ConfirmPassword { get; set; }

		[MaxLength(10)]
        public string? Age { get; set; }

    }
}
