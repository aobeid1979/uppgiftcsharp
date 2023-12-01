using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDatabase
{
    internal class UserManager
    {
        private readonly IDatabase _database;

        public UserManager(IDatabase database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }

        public void AddUser(User user)
        {
            _database.AddUser(user);
        }

        public void RemoveUser(int userId)
        {
            _database.RemoveUser(userId);
        }

        public User GetUser(int userId)
        {
            return _database.GetUser(userId);
        }
    }
}
