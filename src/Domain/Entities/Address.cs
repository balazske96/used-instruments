namespace Domain.Entities;

struct Address
{
    public string Country { get; set; }
    public string PublicSpace { get; set; }
    public int HouseNumber { get; set; }
    public PublicSpaceType PublicSpaceType { get; set; } = PublicSpaceType.STREET;
    public string? AddressAddition { get; set; }

    public Address(
        string country,
        string publicSpace,
        int houseNumber,
        PublicSpaceType? publicSpaceType,
        string? addressAddition
    )
    {
        Country = country;
        PublicSpace = publicSpace;
        HouseNumber = houseNumber;
        AddressAddition = addressAddition;

        if (publicSpaceType != null)
        {
            PublicSpaceType = (PublicSpaceType)publicSpaceType;
        }
    }
}