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

        public static object GetPetList(string family)
        {
            using (var context = new PetShelterEntities())
            {
                var query = from x in context.Pets
                            where x.Familly == family
                            select x;

                return query.ToList();
            }

        }
    }
}
