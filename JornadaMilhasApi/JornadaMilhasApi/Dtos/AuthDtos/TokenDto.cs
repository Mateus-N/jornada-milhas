namespace JornadaMilhasApi.Dtos.AuthDtos;

public record TokenDto
{
    public string AccessToken { get; set; }

    public TokenDto(string accessToken)
    {
        AccessToken = accessToken;
    }
}
