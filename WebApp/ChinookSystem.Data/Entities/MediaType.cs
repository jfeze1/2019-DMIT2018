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
        [Key]
        public int MediaTypeId { get; set; }

        public string Name { get; set; }

        //Navigational Properties
        public virtual ICollection<Track> Tracks { get; set; }
    }

   
}
