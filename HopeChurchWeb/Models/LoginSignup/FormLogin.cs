using System.ComponentModel.DataAnnotations;

namespace HopeChurchWeb.Models.LoginSignup;

public class FormLogin
{
    /// <summary>
    /// 帳號
    /// </summary>
    [Required]
    public string Account { get; set; } = string.Empty;

    /// <summary>
    /// 密碼
    /// </summary>
    [Required]
    public string Password { get; set; } = string.Empty;
}