namespace Domain.Entities;

struct Address
{
    public string Country { get; set; } = "MAGYARORSZÁG";
    public string PublicSpace { get; set; }
    public uint HouseNumber { get; set; }
    public PublicSpaceType PublicSpaceType { get; set; } = PublicSpaceType.STREET;
    public string? AddressAddition { get; set; }

    public Address(
        string country,
        string publicSpace,
        uint houseNumber,
        string? addressAddition
    )
    {
        Country = country;
        PublicSpace = publicSpace;
        HouseNumber = houseNumber;
        AddressAddition = addressAddition;
    }
}