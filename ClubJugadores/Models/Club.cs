using System.ComponentModel.DataAnnotations;

namespace ClubJugadores.Models
{
    public class Club
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del club es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
        [Display(Name = "Nombre del club")]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "La ciudad no puede superar los 100 caracteres.")]
        [Display(Name = "Ciudad")]
        public string? Ciudad { get; set; }

        public ICollection<Jugador> Jugadores { get; set; } = new List<Jugador>();
    }
}