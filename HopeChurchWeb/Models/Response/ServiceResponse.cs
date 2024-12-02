namespace HopeChurchWeb.Models;

public class ServiceResponse
{
    /// <summary>
    /// 是否成功
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 資訊
    /// </summary>
    public string Message { get; set; }

    public ServiceResponse(bool success, string message)
    {
        Success = success;
        Message = message;
    }
}