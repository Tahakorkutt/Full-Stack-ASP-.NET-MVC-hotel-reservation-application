//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelMvcProje.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblOda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblOda()
        {
            this.TblReservations = new HashSet<TblReservation>();
        }
    
        public int OdaID { get; set; }
        public string OdaNo { get; set; }
        public string Kart { get; set; }
        public string Kapasite { get; set; }
        public string Aciklama { get; set; }
        public string Telefon { get; set; }
        public Nullable<int> Durum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblReservation> TblReservations { get; set; }
    }
}
