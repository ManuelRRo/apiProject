//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_USUARIO()
        {
            this.TB_HISTORIAL_ACCIONES = new HashSet<TB_HISTORIAL_ACCIONES>();
            this.TB_ROLES = new HashSet<TB_ROLES>();
        }
    
        public decimal ID_USUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public string USER { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<int> USUARIO_INSERT { get; set; }
        public Nullable<System.DateTime> FECHA_INSERT { get; set; }
        public Nullable<System.DateTime> FECHA_UPDATE { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_HISTORIAL_ACCIONES> TB_HISTORIAL_ACCIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ROLES> TB_ROLES { get; set; }
    }
}
