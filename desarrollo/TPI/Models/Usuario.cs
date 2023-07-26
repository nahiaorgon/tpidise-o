using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Reciplas.Models;

public class Usuario : EntidadBase{
    /// Obtiene o establece el identificador del sector al que pertenece el usuario que genero la ubicacion.

    public int UsuarioId {get; set;}

    public int AreaId {get; set;}

    public Cliente Clientes { get; }
    public Proveedor Proveedores {get;}

}