﻿using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data.Dao
{
    public partial class AdoptionDao : DualKeyDao<Adoption, int, int>
    {
    }
}
