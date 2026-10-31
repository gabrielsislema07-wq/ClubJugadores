# ClubJugadores

Proyecto del Grupo 3: relación uno a muchos entre **Club** y **Jugador** con ASP.NET Core MVC, Entity Framework Core y SQL Server Express.

## Tema asignado

Club-jugador

## Integrantes y aportes

| Integrante | Aporte |
|---|---|
| Juan Gabriel Sislema Collaguazo | Creación del proyecto ClubJugadores, modelo Jugador, controlador y vistas CRUD mediante scaffolding, configuración de SQL Server Express, migración InitialCreate y verificación del funcionamiento en navegador y SSMS. Creación del repositorio en GitHub. |
| Jersson Kevin Vera Rivas | Fase 2 (validaciones): DataAnnotations (`[Required]`, `[StringLength]`, `[Range]`, `[Display]`) con mensajes en español en la entidad Jugador; migración ValidacionesJugador; verificación en SSMS del cambio de `nvarchar(max)` a `nvarchar(100)` y `nvarchar(50)`. |
| Yaneila Judith Charro | Fase 3 (relación uno a muchos): entidad Club con su colección de jugadores; clave foránea ClubId y propiedad de navegación en Jugador; CRUD de Clubes con scaffolding y regeneración del CRUD de Jugadores. |
| Lourdes del Rosario Castillo Huertas | Video explicativo; migración AgregarClub y verificación en SSMS de la tabla Club y la clave foránea FK_Jugador_Club_ClubId. Componente autónomo: lista desplegable de clubes, eliminación del campo duplicado y nombre del club en las vistas de Jugador. |

## Migraciones

1. `InitialCreate`: creación inicial de la tabla Jugador.
2. `ValidacionesJugador`: longitudes y restricciones de las columnas.
3. `AgregarClub`: tabla Club y clave foránea en Jugador.

## Requisitos

- .NET 10 SDK
- Visual Studio con la carga de trabajo de ASP.NET
- SQL Server Express (instancia `localhost\SQLEXPRESS`)
- SQL Server Management Studio (opcional, para verificar la base de datos)
