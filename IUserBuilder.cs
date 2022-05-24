namespace BuilderReturnsFunc
{
    interface IUserBuilder : IUserProps
    {

        UserBuilder SetName(string name);
        UserBuilder SetAge(ushort age);
        User Build();
    }
}
