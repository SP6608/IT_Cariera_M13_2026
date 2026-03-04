using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static CinemaApp.Data.Common.EntityConstants.Movie;
namespace CinemaApp.Data.Models
{
    public  class Movie
    {
        [Comment("Movie identifire")]
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Comment("Movie title")]
        [Required(ErrorMessage ="Title is required")]
        [StringLength(TitleMaxLength,ErrorMessage ="Title cannot exeed 100 characters!")]
        public string Title { get; set; } = null!;
        [Comment("Genre title")]
        [Required(ErrorMessage = "Genre is required")]
        [StringLength(GenreMaxLength, ErrorMessage = "Title cannot exeed 100 characters!")]
        public string Genre { get; set; } = null!;
        [Comment("Relese date")]
        [Required(ErrorMessage = "Relese date is required")]
        public DateTime ReleaseDate { get; set; }
        [Comment("Director title")]
        [Required(ErrorMessage = "Director is required")]
        [StringLength(DirectorMaxLength, ErrorMessage = "Director cannot exeed 100 characters!")]
        public string Director { get; set; } = null!;
        public int Duration { get; set; }
        public string Description { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public bool IsDeleted { get; set; } = false;

        //public virtual ICollection<CinemaMovie> MovieCinemas { get; set; }
        //    = new HashSet<CinemaMovie>();

        //public virtual ICollection<ApplicationUserMovie> MovieApplicationUsers { get; set; }
        //    = new HashSet<ApplicationUserMovie>();

        //public virtual ICollection<Ticket> Tickets { get; set; }
        //    = new HashSet<Ticket>();
    }
}
