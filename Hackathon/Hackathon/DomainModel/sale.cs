//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace Hackathon.DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class sale
    {
        [Key]
        public int SalesId { get; set; }
        public string strap { get; set; }
        public string folio { get; set; }
        public Nullable<int> ln_num { get; set; }
        public string trns_cd { get; set; }
        public string or_bk { get; set; }
        public string or_pg { get; set; }
        public string grantor { get; set; }
        public string grantee { get; set; }
        public Nullable<System.DateTime> dos { get; set; }
        public Nullable<int> price { get; set; }
        public string vi { get; set; }
        public string qu_flg { get; set; }
        public Nullable<decimal> doc_stamps { get; set; }
        public string rea_cd { get; set; }
    }
}
