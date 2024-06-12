namespace Restaurant.Shared.Request;

public class LoginDTORequest
{
    public string Usuario { get; set; } = default!;
    public string Password { get; set; } = default!;
}
