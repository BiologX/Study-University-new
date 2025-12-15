using System.ComponentModel.DataAnnotations;

namespace StoreOnline.API.Contracts.Users.Request
{
    public class UpdateUserRequest
    {
        [Required(ErrorMessage = "Id пользователя обязателен")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Имя пользователя обязательно")]
        [StringLength(50, ErrorMessage = "Имя не может превышать 50 символов")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Логин обязателен")]
        [StringLength(20, ErrorMessage = "Логин не может превышать 20 символов")]
        public string Login { get; set; } = string.Empty;

        [Required(ErrorMessage = "Пароль обязателен")]
        [MinLength(6, ErrorMessage = "Пароль должен содержать минимум 6 символов")]
        public string Password { get; set; } = string.Empty;
    }
}
