using System.ComponentModel.DataAnnotations;

namespace Reciplas.Models;

/// <summary>
/// Clase base para modelos del dominio.
/// </summary>
public abstract class EntidadBase
{
    /// <summary>
    /// Obtiene o establece el identificador de la entidad.
    /// </summary>
    /// <value>Numerico entero.</value>
    [Key]
    public int Id { get; set; }
}
