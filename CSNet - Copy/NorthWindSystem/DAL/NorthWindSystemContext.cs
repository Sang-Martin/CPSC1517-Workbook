using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using NorthWindSystem.Entities;
#endregion

namespace NorthWindSystem.DAL
{
     //connect this class to the EntityFramework by inheriting DbContext
     //     which is within the System.Data.Entity library
     //we want to restrict access to this class to ONLY other classes int
     //     the same project.
     //therefore the access is internal
     internal class NorthWindSystemContext : DbContext
    {
        //you will need a contrucstor that passes the connection string name to EntityFramework via the inherited DbContext class
        public NorthWindSystemContext(): base("NWDB")
        {
            //default constructor
        }

        //properties to interact with EntityFramework
        //these properties represent the whole table and all data of the sql database
        
        // DbSet<> is point to entity
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}
