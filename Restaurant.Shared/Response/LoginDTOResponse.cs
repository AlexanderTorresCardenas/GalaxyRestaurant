namespace Restaurant.Shared.Response;

public class LoginDTOResponse : BaseResponse
{
    public string Token { get; set; } = default!;
    public string NombreCompleto { get; set; } = default!;
    public List<string> Roles { get; set; } = default!;
}
