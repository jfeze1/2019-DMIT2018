using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using ChinookSystem.DAL;
using ChinookSystem.Data.Entities;
using System.ComponentModel; //For ODS
#endregion


namespace ChinookSystem.BLL
{
    
    public class AlbumController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Album> Album_List()
        {
            using (var context = new ChinookSystemContext())
            {
                //The entity framework return an IEnumerable or IQueryable DbSet
                //Since this method expects to return a List<T>
                //the DbSet needs to be case to that data type
                //To case the DbSet to List<T> use .ToList()
                return context.Albums.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Album Albumt_Get(int albumid)
        {
            using (var context = new ChinookSystemContext())
            {
                return context.Albums.Find(albumid);
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Album> Album_GetByArtist(int artistid)
        {
            using (var context = new ChinookSystemContext())
            {
                var results = from x in context.Albums
                              where x.ArtistId == artistid
                              select x;
                return results.ToList();
            }
        }
    }
}
