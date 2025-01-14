namespace HopeChurchWeb.Models;

public class SaveLink
{
    /// <summary>
    /// 員工 ID
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// 連結 ID
    /// </summary>
    public int LinkId { get; set; }

    /// <summary>
    /// 是否收藏
    /// </summary>
    public bool IsFavorite { get; set; }
}