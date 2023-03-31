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
    public int Id { get; set; }
}
