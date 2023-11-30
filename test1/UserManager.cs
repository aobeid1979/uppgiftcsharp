using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Database : IDatabase
    {
        private List<User> users;

        public Database()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
            Console.WriteLine($"User {user.UserName} has been added to the database.");
        }

        public void RemoveUser(int userId)
        {
            User userToRemove = users.FirstOrDefault(u => u.UserId == userId);
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
                Console.WriteLine($"User with ID {userId} has been removed from the database.");
            }
            else
            {
                Console.WriteLine($"User with ID {userId} could not be found in the database.");
            }
        }

        public User GetUser(int userId)
        {
            return users.FirstOrDefault(u => u.UserId == userId);
        }
    }
}
