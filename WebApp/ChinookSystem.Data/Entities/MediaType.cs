using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ChinookSystem.Data.Entities;
#endregion

namespace Chinookystem.Data.Entities
{
    [Table("MediaTypes")]
    public class MediaType
    {
        public string _Name;

        [Key]
        public int MediaTypeId { get; set; }

        [StringLength(120, ErrorMessage ="Name should have a maximum of 120 characters")]
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

        //Navigational Properties
        public virtual ICollection<Track> Tracks { get; set; }
    }

   
}
