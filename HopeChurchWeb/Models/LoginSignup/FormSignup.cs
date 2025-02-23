using System.ComponentModel.DataAnnotations;

namespace HopeChurchWeb.Models;

public class FormSignup
{
    /// <summary>
    /// 帳號
    /// </summary>
    [Required(ErrorMessage = "帳號為必填")]
    public string Account { get; set; } = string.Empty;

    /// <summary>
    /// E-mail
    /// </summary>
    [Required(ErrorMessage = "請輸入電子郵件")]
    [EmailAddress(ErrorMessage = "請輸入正確的電子郵件格式")]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// 密碼
    /// </summary>
    [Required(ErrorMessage = "請輸入密碼")]
    public string Password { get; set; } = string.Empty;
}