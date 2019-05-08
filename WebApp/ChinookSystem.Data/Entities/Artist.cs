using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace ChinookSystem.Data.Entities
{
    //Default class permission is private
    //Annotation to link this class to the sql table
    [Table("Artits")]
    public class Artist
    {
        private string _Name;
        [Key]
        public int ArtistId { get; set; } // This is an automated implemented property

        // Because Name is a nullable field we make sure we handle it in our class by creating a private property _Name
        //Always Fully implement nullable field string property
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    _Name = null; 
                }
                else
                {
                    _Name = value;
                }
            }
        }

    }
}
