//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Site
{
    using System;
    using System.Collections.Generic;
    
    public partial class Preco
    {
        public int id { get; set; }
        public int idProduto { get; set; }
        public Nullable<decimal> Preco1 { get; set; }
        public Nullable<System.DateTime> DataVigencia { get; set; }
    
        public virtual Produto Produto { get; set; }
    }
}
