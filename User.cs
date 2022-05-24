using System;

namespace BuilderReturnsFunc
{
    class User : IUserProps, IUserActions
    {
        public string Name { get; }
        public ushort Age { get; }

        public User(string name, ushort age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString() => $"{this.Name} has {this.Age} years old.";

        public void WhenBuilt(Action<User> action)
        {
            action(this);
        }
    }
}
