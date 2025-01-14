using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HopeChurchWeb.Models;

public class FavoriteLink
{
    /// <summary>
    /// 流水號
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// 使用者 ID
    /// </summary>
    [Required]
    public int UserId { get; set; }

    /// <summary>
    /// 連結 ID
    /// </summary>
    [Required]
    public int LinkId { get; set; }
}