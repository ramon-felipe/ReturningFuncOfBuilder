using System;

namespace BuilderReturnsFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var getUser = p.GetUser("Ramon", 15);

            var user = getUser.Invoke();

            user.WhenBuilt(p.Test);

            Console.WriteLine(user.ToString());
            Console.ReadKey();
        }

        private void Test(User user)
        {
            Console.WriteLine("O usuário {0} foi criado!", user.Name);
        }

        private Func<User> GetUser(string name, ushort age)
        {
            var userBuilder = new UserBuilder();
            return userBuilder
                .SetName(name)
                .SetAge(age)
                .Build;
        }
    }
}
