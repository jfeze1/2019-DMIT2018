using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using ChinookSystem.Data.Entities;
using Chinookystem.Data.Entities;
#endregion

namespace ChinookSystem.DAL
{
    internal class ChinookSystemContext : DbContext
    {
        //construcytors to pass on the connection string name to DbContext
        public ChinookSystemContext() : base("ChinookDB")
        {

        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<MediaType> ArtiMediaTypessts { get; set; }
    }
}
