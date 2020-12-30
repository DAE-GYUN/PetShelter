using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data.Dao
{
    public class Dao
    {
        public static AdoptionDao Adoption = new AdoptionDao();

        public static UserDao User = new UserDao();

        public static PetDao Pet = new PetDao();
    }
}
