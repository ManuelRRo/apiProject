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
    
    public partial class TB_TIPOS_CUENTAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_TIPOS_CUENTAS()
        {
            this.TB_CUENTAS_BANCARIAS = new HashSet<TB_CUENTAS_BANCARIAS>();
        }
    
        public decimal ID_TIPO_CUENTA { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<int> USUARIO_INSERT { get; set; }
        public Nullable<System.DateTime> FECHA_INSERT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_CUENTAS_BANCARIAS> TB_CUENTAS_BANCARIAS { get; set; }
    }
}