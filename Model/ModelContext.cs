using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsLibraryManager.Database;

namespace WinformsLibraryManager.Model
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("SchoolDBConnectionString")
        {
            System.Data.Entity.Database.SetInitializer(new DatabaseInitializer());
        }
    }
}
