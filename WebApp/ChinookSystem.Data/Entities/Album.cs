using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace ChinookSystem.Data.Entities
{
    [Table("Albums")]
    public class Album
    {
        private string _ReleasedLabel;

        [Key]
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public int ReleasedYear { get; set; }
        public string ReleasedLabel
        {
            get
            {
                return _ReleasedLabel;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _ReleasedLabel = null;
                }
                else
                {
                    _ReleasedLabel = value;
                }
            }
        }
    }
}
