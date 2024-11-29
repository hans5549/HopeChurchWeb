using System.ComponentModel.DataAnnotations;

namespace HopeChurchWeb.Models;

/// <summary>
/// 忘記密碼驗證資訊
/// </summary>
public class ForgetPasswordVerification
{
    /// <summary>
    /// 姓名
    /// </summary>
    [Required(ErrorMessage = "請輸入姓名")]
    public string Account { get; set; } = string.Empty;

    /// <summary>
    /// E-mail
    /// </summary>
    [Required(ErrorMessage = "請輸入 E-mail")]
    [EmailAddress(ErrorMessage = "請輸入有效的 E-mail 格式")]
    public string Email { get; set; } = string.Empty;
}