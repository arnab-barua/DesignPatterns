namespace BuilderPattern;
internal class UserBuilder
{
    private readonly User user;

    public UserBuilder(string name)
    {
        user = new User(name);
    }


    public UserBuilder SetPhone(string phoneNumber)
    {
        user.PhoneNumber = phoneNumber;
        return this;
    }

    public UserBuilder SetEmail(string email)
    {
        user.Email = email;
        return this;
    }

    public UserBuilder SetAddress(Address address)
    {
        user.Address = address;
        return this;
    }

    public User Build()
    {
        return user;
    }
}
