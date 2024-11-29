using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HopeChurchWeb.Models;

[Table("UserMain", Schema = "user")]
public class UserMain
{
    /// <summary>
    /// 流水號
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// 帳號
    /// </summary>
    [Required]
    [StringLength(50)]
    public string Account { get; set; } = string.Empty;

    /// <summary>
    /// Email
    /// </summary>
    [Required]
    [EmailAddress]
    [StringLength(100)]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// 密碼
    /// </summary>
    [Required]
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// 使用中
    /// </summary>
    public bool IsActive { get; set; } = true;
}