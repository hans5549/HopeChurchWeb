using System.ComponentModel.DataAnnotations;

namespace HopeChurchWeb.Models.LoginSignup;

/// <summary>
/// 密碼重設資訊
/// </summary>
public class PasswordReset
{
    /// <summary>
    /// 密碼
    /// </summary>
    [Required(ErrorMessage = "請輸入密碼")]
    public string MainPassword { get; set; } = string.Empty;

    /// <summary>
    /// 驗證密碼
    /// </summary>
    [Required(ErrorMessage = "請輸入驗證密碼")]
    [Compare(nameof(MainPassword), ErrorMessage = "兩次密碼輸入不相符")]
    public string SubPassword { get; set; } = string.Empty;
}