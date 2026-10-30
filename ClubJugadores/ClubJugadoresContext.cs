using Microsoft.EntityFrameworkCore;

public class ClubJugadoresContext(DbContextOptions<ClubJugadoresContext> options) : DbContext(options)
{
    public DbSet<ClubJugadores.Models.Jugador> Jugador { get; set; } = default!;
}
