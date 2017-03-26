using System;

namespace Source.Models
{
    public interface IEmailSender
    {
        void SendMessage(string from, string to, string message);
    }

    public interface IDatabase
    {
        bool IsConnected { get; }
        void Connect();
        void Disconnect();
        void SaveChanges();
    }

    public interface IUserService
    {
        Result<User> Register(string email, string password);
    }

    public class EmailSender : IEmailSender
    {
        public void SendMessage(string from, string to, string message)
        {
           Console.WriteLine($"Sending message {from} -> {to} -> {message}.");
        }
    }

    public class Database : IDatabase
    {
        public bool IsConnected { get; private set; }

        public void Connect()
        {
            IsConnected = true;
            Console.WriteLine("Connected to the database.");
        }

        public void Disconnect()
        {
            IsConnected = false;
            Console.WriteLine("Disconnected from the database.");
        }

        public void SaveChanges()
        {
            Console.WriteLine("Saved changes to the database.");
        }
    }

    public class UserService : IUserService
    {
        private readonly IDatabase _database;
        private readonly IEmailSender _emailSender;

        public UserService(IDatabase database, IEmailSender emailSender)
        {
            _database = database;
            _emailSender = emailSender;
        }

        public Result<User> Register(string email, string password)
        {
            var user = new User(email, password);
            _database.Connect();
            _database.SaveChanges();
            _database.Disconnect();
            _emailSender.SendMessage("system@email.com", email, "New account was created.");

            return new Result<User>(user);
        }
    }

    public class FakeEmailSender : IEmailSender
    {
        public void SendMessage(string from, string to, string message)
        {
            Console.WriteLine($"Sending fake message {from} -> {to} -> {message}.");
        }
    }
}