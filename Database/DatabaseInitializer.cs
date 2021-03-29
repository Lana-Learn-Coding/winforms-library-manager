using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsLibraryManager.Model;

namespace WinformsLibraryManager.Database
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<ModelContext>
    {
    }
}
