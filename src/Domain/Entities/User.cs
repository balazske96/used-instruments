namespace Domain.Entities;

class User : IEquatable<User>
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string? Password { get; set; }
    public List<Instrument>? Instruments { get; set; }

    public User(string lastName, string firstName, string email, string phone)
    {
        LastName = lastName;
        FirstName = firstName;
        Email = email;
        Phone = phone;
    }

    public bool Equals(User? other)
    {
        if (other == null)
        {
            return false;
        }

        return this.Id.ToString() == other.Id.ToString();
    }
}