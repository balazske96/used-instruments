namespace Domain.Entities;

class User
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string? Username { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Phone { get; set; }
    public string? Password { get; set; }
    public List<Instrument> Instruments { get; set; } = new();
    public uint Upvotes { get; set; }
    public uint Downvotes { get; set; }
    public Image? ProfilePicture { get; set; }

    public User(
        string username,
        string lastName,
        string firstName,
        string email,
        string phone
    )
    {
        Username = username;
        LastName = lastName;
        FirstName = firstName;
        Email = email;
        Phone = phone;
    }
}