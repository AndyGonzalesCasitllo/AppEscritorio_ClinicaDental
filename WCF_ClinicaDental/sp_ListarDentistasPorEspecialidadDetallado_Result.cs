//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_ClinicaDental
{
    using System;
    
    public partial class sp_ListarDentistasPorEspecialidadDetallado_Result
    {
        public int idUsuario { get; set; }
        public string dni { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public Nullable<int> edad { get; set; }
        public Nullable<int> sexo { get; set; }
        public string rol { get; set; }
        public Nullable<int> estadoUsuario { get; set; }
        public int idDentista { get; set; }
        public Nullable<int> estadoDentista { get; set; }
        public string especialidadNombre { get; set; }
        public string especialidadDescripcion { get; set; }
    }
}
