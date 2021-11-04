using System;
using System.Collections.Generic;
using System.Linq;
using Assignment2.Models;

namespace Assignment2.Data
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    UserName = "xandrusia",
                    City = "Horsens",
                    BirthYear = 2000,
                    Password = "xandrusia!",
                    Role = "Student",
                    SecurityLevel = 4
                },
                new User
                {
                    UserName = "jupaja",
                    City = "Horsens",
                    BirthYear = 2000,
                    Password = "jupaja!",
                    Role = "Student",
                    SecurityLevel = 4
                },
                new User
                {
                    UserName = "guest",
                    City = "Aarhus",
                    BirthYear = 2000,
                    Password = "guest!",
                    Role = "Guest",
                    SecurityLevel = 2
                }
            }.ToList();
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}