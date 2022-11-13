namespace Domain.Entities;

class Instrument
{
    public Guid Id { get; set; }
    public User Owner { get; init; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public Condition Condition { get; set; }
    public Address Address { get; set; }
    public DateTime PublishedAt { get; set; }
    public List<Image> Images { get; set; } = new();
    public InstrumentState State { get; set; } = InstrumentState.DRAFT;

    public Instrument(
        User owner,
        Address address,
        Condition condition,
        string name,
        string description,
        int price
    )
    {
        Owner = owner;
        Name = name;
        Description = description;
        Price = price;
        Address = address;
        Condition = condition;
    }
}