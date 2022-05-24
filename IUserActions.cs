using System;

namespace BuilderReturnsFunc
{
    interface IUserActions
    {
        void WhenBuilt(Action<User> action);
    }
}
