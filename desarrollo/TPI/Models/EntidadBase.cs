using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;

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
