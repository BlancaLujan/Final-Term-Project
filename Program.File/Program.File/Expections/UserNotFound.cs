using System;
namespace Program.File.Expections
{
    public class UserNotFound : Exception

    {
        public UserNotFound(string errorMessage) : base(errorMessage)
        {
        }
    }
}
        // try
         //       {
               //     User myUser = new User();

     //   myUser.ExecuteMainMenu();
               // }
        //        catch (UserNotFound exception)
       //         {
                    //Console.WriteLine(exception.Message);
        //
//    }
//}
