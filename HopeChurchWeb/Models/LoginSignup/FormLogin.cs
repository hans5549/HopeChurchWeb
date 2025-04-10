using System.ComponentModel.DataAnnotations;
using HopeChurchWeb.Common.Enum;

namespace HopeChurchWeb.Models;

public class FormLogin
{
    /// <summary>
    /// 帳號類型
    /// </summary>
    public string LoginMode { get; set; } = LoginModeEnum.Church.ToString().ToLower();

    /// <summary>
    /// 帳號
    /// </summary>
    [Required(ErrorMessage = "請輸入姓名或 Email")]
    public string Account { get; set; } = string.Empty;

    /// <summary>
    /// 密碼
    /// </summary>
    [Required(ErrorMessage = "請輸入密碼")]
    public string Password { get; set; } = string.Empty;
}