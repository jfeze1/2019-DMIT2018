using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Chinookystem.Data.Entities;
#endregion
namespace ChinookSystem.Data.Entities
{
    [Table("Tracks")]
    public class Track
    {
        private string _Composer;
        [Key]
        public int TrackId { get; set; }

        [Required(ErrorMessage ="The Name is a required")]
        [StringLength(200, ErrorMessage ="Name should have a maximum of 200 characters")]
        public string Name { get; set; }

        public int? AlbumId { get; set; }

        public int MediaTypeId { get; set; }

        public int? GenreId { get; set; }

        [StringLength(220, ErrorMessage ="The composer should have a maximum of 220 characters")]
        public string Composer
        {
            get
            {
                return _Composer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Composer = null;
                }
                else
                {
                    _Composer = value;
                }
            }
        }

        [Required(ErrorMessage ="Miliseconds is required")]
        [Range(0, int.MaxValue, ErrorMessage ="Invalid miliseconds")]
        public int Milliseconds { get; set; }

        [Range(0, int.MaxValue, ErrorMessage ="Invalid bytes")]
        public int? Bytes { get; set; }

        [Required(ErrorMessage ="The unit price is required")]
        [Range(0.00, 99999999.99, ErrorMessage ="The value of the unit price should be in between 0.00 and 99999999.99, both values included")]
        public decimal UnitPrice { get; set; }

        //Navigational Properties
        public virtual Album Album { get; set; }
        public virtual MediaType MediaType { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
