namespace BuilderPattern;
internal record User
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Address Address { get; set; }

    public User(string name)
    {
        Name = name;
    }
}

internal record Address
{
    public string City { get; set; }
    public string State { get; set; }
}