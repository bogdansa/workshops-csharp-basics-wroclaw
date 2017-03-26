using System;

namespace Source.Models
{
    public class User : Person
    {
        public string Email { get; private set; }
        public string Password { get; protected set; }

        public User(string email, string password)
        {
            UpdateEmail(email);
            UpdatePassword(password);
        }

        public virtual void DisplayEmail()
        {
            Console.WriteLine($"User: {Email}");
        }

        public void UpdateEmail(string email)
        {
            ValidateValue(email);
            Email = email;
        }

        public void UpdatePassword(string password)
        {
            ValidateValue(password);
            Password = password;
        }

        private void ValidateValue(string value)
        {
            if(value.IsEmpty())
            {
                throw new InvalidValueException("Invalid value.");
            }
        }

        public override void DisplayName()
        {
            Console.WriteLine("I'm user");
            throw new ArgumentException();
        }
  }

    public class InvalidValueException : Exception
    {
        public InvalidValueException(string message) : base(message)
        {
        }
    }
}