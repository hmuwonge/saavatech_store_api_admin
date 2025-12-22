namespace Ecommerce.Shared.Responses;

public class ApiResponse<T>
{
    public bool Success { get; set; }
    public string? Error { get; init; }
    public T? Data { get; init; }
}