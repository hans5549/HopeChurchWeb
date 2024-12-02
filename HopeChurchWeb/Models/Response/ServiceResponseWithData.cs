namespace HopeChurchWeb.Models;

public class ServiceResponseWithData<T>
{
    /// <summary>
    /// 是否成功
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 資訊
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// 資料
    /// </summary>
    public T? Data { get; set; }
}