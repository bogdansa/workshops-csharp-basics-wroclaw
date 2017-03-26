using System;
using System.Collections.Generic;
using Source.Models;

namespace Source
{
    public class Sandbox
    {
        public static void Run()
        {
            IEmailSender emailSender = new FakeEmailSender();
            IDatabase database = new Database();
            IUserService userService = new UserService(database, emailSender);

            try
            {
                var user = userService.Register("user1@email.com", "secret");
                user.Item.DisplayName();
            }
            catch(InvalidValueException exception)
            {
                Console.WriteLine($"My exception: {exception.Message}.");
            }
            catch(Exception exception)
            {
                Console.WriteLine($"Error: {exception.Message}.");
                throw;
            }
            // finally
            // {
            //     Console.WriteLine($"Finally");
            // }

            // var user = new User("user@email.com", "secret");
            // user.Item.DisplayEmail();
            // var admin = new Administrator("admin@email.com", "secret");
            // admin.DisplayEmail();

            // List<User> users = new List<User>
            // {
            //     user.Item, admin
            // };

            // foreach(var currentUser in users)
            // {
            //     // currentUser.DisplayEmail();
            // }
            // DisplayEmail(user.Item);
            // DisplayEmail(admin);
        }

        public static void DisplayEmail(User user)
        {
            Administrator admin = user as Administrator;
            if(admin != null)
            {
                admin.DisplayEmail();
            }
            else
            {
                Console.WriteLine("Admin is null");
            }
            user.DisplayEmail();
        }   
    }
}