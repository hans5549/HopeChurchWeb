using System.ComponentModel.DataAnnotations;

namespace HopeChurchWeb.Models;

public class FormAddLink
{
    /// <summary>
    /// 連結名稱
    /// </summary>
    [Required]
    [StringLength(50)]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// 說明
    /// </summary>
    [StringLength(500)]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// 連結
    /// </summary>
    [Required]
    public string Url { get; set; } = string.Empty;
}