using BuilderPattern;

Console.WriteLine("Hello, World!");

UserBuilder builder = new("Mike");

builder.SetEmail("mike@gmail.com")
    .SetAddress(new Address { City = "Dhaka"})
    .SetPhone("01223366");

var user = builder.Build();

Console.WriteLine(user);