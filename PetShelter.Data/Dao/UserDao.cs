﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EFLibrary;

namespace PetShelter.Data.Dao
{
    public partial class UserDao : SingleKeyDao<User, int>
    {
        protected override Expression<Func<User, int>> KeySelector => x => x.UserID;

    }
}
