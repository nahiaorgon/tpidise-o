namespace Reciplas.Models;

public class Usuario : EntidadBase{
    /// Obtiene o establece el identificador del sector al que pertenece el usuario que genero la ubicacion.

    public int UsuarioId {get; set;}

    public int AreaId {get; set;}

    public Cliente Clientes { get; }
    public Proveedor Proveedores {get;}

}