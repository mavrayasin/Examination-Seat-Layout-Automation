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
    
    public partial class SinavListe
    {
        public int ID { get; set; }
        public int SinavID { get; set; }
        public int DerslikID { get; set; }
        public int OgrenciID { get; set; }
        public int SiraNo { get; set; }
    
        public virtual Derslik Derslik { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
        public virtual Sinav Sinav { get; set; }
    }
}
