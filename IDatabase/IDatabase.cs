﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDatabase
{
    public interface IDatabase
    {
        void AddUser(User user);
        void RemoveUser(int userId);
        User GetUser(int userId);
    }
}
