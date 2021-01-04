using PetShelter.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary
{
    public class DbContextCreator
    {
        private const string ConnectionString = "metadata=res://*/PetShelter.csdl|res://*/PetShelter.ssdl|res://*/PetShelter.msl;provider=System.Data.SqlClient;provider connection string=\"data source=cn76.ipdisk.co.kr,3423;initial catalog=PetShelter;user id=8F;password=1;MultipleActiveResultSets=True;App=EntityFramework\"";

        public static PetShelterEntities Create()
        {
            var context = new PetShelterEntities(ConnectionString);
            
            context.Configuration.ProxyCreationEnabled = false;
            context.Configuration.LazyLoadingEnabled = false;
            context.Configuration.AutoDetectChangesEnabled = false;

            return context;
        }
    }
}

namespace PetShelter.Data
{
    public partial class PetShelterEntities
    {
        public PetShelterEntities(string connectionString) : base(connectionString)
        {
        }
    }
}
