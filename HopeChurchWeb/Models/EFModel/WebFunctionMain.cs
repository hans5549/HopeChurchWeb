using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HopeChurchWeb.Models;

public class WebFunctionMain
{
    /// <summary>
    /// 流水號
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// 功能名稱
    /// </summary>
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 是否為分類項目
    /// </summary>
    public bool IsCategory { get; set; } = false;

    public int ParentId { get; set; } = 1;

    /// <summary>
    /// 圖示
    /// </summary>
    [Required]
    [StringLength(50)]
    public string icon { get; set; } = string.Empty;

    /// <summary>
    /// 連結
    /// </summary>
    [Required]
    [StringLength(20)]
    public string url { get; set; } = string.Empty;

    /// <summary>
    /// 啟動
    /// </summary>
    public bool IsActive { get; set; } = false;
}