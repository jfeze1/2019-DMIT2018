using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

//Entitty validation kicks in on the .SaveChanges() command
namespace ChinookSystem.Data.Entities
{
    [Table("Albums")]
    public class Album
    {
        private string _ReleaseLabel;

        [Key]
        public int AlbumId { get; set; }
        [Required(ErrorMessage ="The title is required")]
        [StringLength(160, ErrorMessage ="Title is limited to 160 characters")]
        public string Title { get; set; }
        public int ArtistId { get; set; }
        [Range(1950, 2019, ErrorMessage ="Release year must be between 1950 and tody")]
        public int ReleaseYear { get; set; }
        [StringLength(50, ErrorMessage ="Release label limited to 50 characters")]
        public string ReleaseLabel
        {
            get
            {
                return _ReleaseLabel;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _ReleaseLabel = null;
                }
                else
                {
                    _ReleaseLabel = value;
                }
            }
        }
        [NotMapped]
        public string LabelYear
        {
            get
            {
                if (string.IsNullOrEmpty(ReleaseLabel))
                {
                    return "Unknown label (" + ReleaseYear.ToString() + ")";
                }
                else
                {
                    return ReleaseLabel + "(" + ReleaseLabel + " (" + ReleaseYear.ToString() + ")";
                }
            }
        }
        //Navigation properties
        // Album has only one artist as a parent
        public virtual Artist Artist { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
