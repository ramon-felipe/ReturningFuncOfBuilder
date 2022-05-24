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

        /// <summary>
        /// The callback function will be executed when the age of the user is greater or equal to 18
        /// </summary>
        /// <param name="action"></param>
        public void WhenBuilt(Action<User> action)
        {
            if(this.Age >= 18)
                action(this);
        }
    }
}
