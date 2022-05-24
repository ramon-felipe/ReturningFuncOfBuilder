namespace BuilderReturnsFunc
{
    class UserBuilder : IUserBuilder
    {
        public string Name { get; private set; }
        public ushort Age { get; private set; }

        public User Build() => new(this.Name, this.Age);
        

        public UserBuilder SetAge(ushort age)
        {
            this.Age = age;

            return this;
        }

        public UserBuilder SetName(string name)
        {
            this.Name = name;

            return this;
        }
    }
}
