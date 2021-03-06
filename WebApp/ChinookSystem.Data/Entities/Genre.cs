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
    [Table("Genres")]
    public class Genre
    {

        private string _Name;

        [Key]
        public int GenreId { get; set; }
        [StringLength(120, ErrorMessage ="The name should have a maximum of 120 characters")]
        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Name = null;
                }
                else
                {
                    _Name = value;
                }
            }
        }

        public virtual ICollection<Track> Tracks { get; set; }
    }

   
}
