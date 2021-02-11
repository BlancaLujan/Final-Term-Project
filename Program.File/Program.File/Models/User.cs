using System;
namespace Program.File.MyClasses
{
    public class User
    {
        public User()
        {
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserList { get; set; }
        public string UserRole { get; set; }
        public string Email { get; set; }

        internal void ExecuteMainMenu()
        {
            throw new NotImplementedException();
        }

        public string Password { get; set; }

        public override string ToString()
        {
            string format = "User Id [{0}], Username [{1}], Password [{2}], Email [{3}]";
            return string.Format(format, UserId, UserName, Password, Email);
        }





    }

    internal class MyMethod
    {
    }
}
