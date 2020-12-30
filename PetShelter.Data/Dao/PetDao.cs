using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EFLibrary;

namespace PetShelter.Data.Dao
{
    public partial class PetDao : SingleKeyDao<Pet, int>
    {
        protected override Expression<Func<Pet, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Pet, bool>> IsKey(int key)
        {
            throw new NotImplementedException();
        }
    }
}
