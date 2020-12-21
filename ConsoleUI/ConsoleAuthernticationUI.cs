using System;
using xp.auth.core.services.Validation;

namespace xp.auth.console.ui
{

    public class ConsoleAuthernticationUI
    {
        [STAThread]
        private static void Main(string[] args)
        {
            bool result;

            ConsoleAdaptor adaptor = new ConsoleAdaptor(new Validator());
            
            adaptor.StartOperation();
            if (adaptor.ValidateOperation())
            {
                adaptor.GetUserDetails();

                if (adaptor.ValidateUser())
                {
                    result = adaptor.AddUser(false);

                    if (result)
                        Console.WriteLine("The user : " + adaptor.User.username + " added successfully");
                    else
                        Console.WriteLine("Failed to add a new user");
                }

                else
                    Console.WriteLine("Please enter a valid user name");
            }
            else
                Console.WriteLine("Please enter a valid option");



            //   Console.WriteLine("Hello World!");
        }
    }
}
