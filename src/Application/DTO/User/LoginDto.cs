namespace Application.DTO.User;

record LoginDTO
{
    public string Identifier { get; init; }
    public string? Password { get; init; }

    public LoginDTO(string identifier)
    {
        Identifier = identifier;
    }
}