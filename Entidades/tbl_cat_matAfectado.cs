//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_cat_matAfectado
    {
        public tbl_cat_matAfectado()
        {
            this.tbl_incidencias = new HashSet<tbl_incidencias>();
        }
    
        public int id_material { get; set; }
        public string cve_material { get; set; }
        public string nom_material { get; set; }
    
        public virtual ICollection<tbl_incidencias> tbl_incidencias { get; set; }
    }
}
