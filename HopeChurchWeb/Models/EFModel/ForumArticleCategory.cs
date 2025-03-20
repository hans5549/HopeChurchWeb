using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HopeChurchWeb.Models;

public class ForumArticleCategory
{
    /// <summary>
    /// 流水號
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int ParentId { get; set; }

    /// <summary>
    /// 名稱
    /// </summary>
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 是否顯示
    /// </summary>
    public bool IsVisible { get; set; }

    public int SortId { get; set; }
}