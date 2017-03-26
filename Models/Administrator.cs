using System;

namespace Source.Models
{
    public class Administrator : User
    {
        public bool IsActive { get; private set; }

        public Administrator(string email, string password) 
            : base(email, password)
        {
        }

        public override void DisplayEmail()
        {
            Console.WriteLine($"Admin");
            base.DisplayEmail();
        }

        public void Activate()
        {
            IsActive = true;
        }

        public void Deactivate()
        {
            IsActive = false;
            // Password = string.Empty;
        }
    }
}