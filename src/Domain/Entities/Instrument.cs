namespace Domain.Entities;

public class Instrument : EntityWithId
{
    public User Owner { get; init; }
    public string Name { get; set; }
    public string Description { get; set; }
    public uint Price { get; set; }
    public Condition Condition { get; set; } = Condition.USED;
    public Address Address { get; set; }
    public DateTime? CreatedAt { get; set; }
    public List<Image> Images { get; set; } = new();
    public InstrumentState State { get; set; } = InstrumentState.DRAFT;

    public Instrument(
        User owner,
        Address address,
        Condition condition,
        string name,
        string description,
        uint price
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