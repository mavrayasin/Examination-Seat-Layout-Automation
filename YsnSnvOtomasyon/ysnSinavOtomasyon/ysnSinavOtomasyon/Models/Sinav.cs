//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ysnSinavOtomasyon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sinav
    {
        public Sinav()
        {
            this.SinavListe = new HashSet<SinavListe>();
        }
    
        public int SinavId { get; set; }
        public string SinavAdi { get; set; }
        public System.DateTime SinavTarihi { get; set; }
    
        public virtual ICollection<SinavListe> SinavListe { get; set; }
    }
}
