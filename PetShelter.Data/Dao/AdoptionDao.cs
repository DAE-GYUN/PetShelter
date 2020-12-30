using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data.Dao
{
    public partial class AdoptionDao : SingleKeyDao<Adoption, int>
    {
        protected override Expression<Func<Adoption, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Adoption, bool>> IsKey(int key)
        {
            throw new NotImplementedException();
        }
    }
}
