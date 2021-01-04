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
        protected override Expression<Func<Pet, int>> KeySelector => x => x.PetID;

        //protected override Expression<Func<Pet, bool>> IsKey(int key)
        //{
        //    return x => x.PetID == key;
        //}

        public List<Pet> GetPetList(string family)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Pets
                            where x.Familly == family
                            select x;

                return query.ToList();
            }

        }
    }
}
