using System.ComponentModel.DataAnnotations;

namespace ClubJugadores.Models
{
    public class Jugador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres.")]
        [Display(Name = "Nombre del jugador")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La posición es obligatoria.")]
        [StringLength(50, ErrorMessage = "La posición no puede superar los 50 caracteres.")]
        [Display(Name = "Posición")]
        public string Posicion { get; set; } = string.Empty;

        [Required(ErrorMessage = "El número de camiseta es obligatorio.")]
        [Range(1, 99, ErrorMessage = "El número de camiseta debe estar entre 1 y 99.")]
        [Display(Name = "Número de camiseta")]
        public int NumeroCamiseta { get; set; }

        // Relación uno a muchos: cada jugador pertenece a un club
        [Display(Name = "Club")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un club.")]
        public int ClubId { get; set; }

        public Club? Club { get; set; }
    }
}