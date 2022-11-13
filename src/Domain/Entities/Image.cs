namespace Domain.Entities;

class Image
{
    public string Src { get; set; }
    public User Owner { get; set; }
    public Image(User owner, string src)
    {
        Owner = owner;
        Src = src;
    }
}
