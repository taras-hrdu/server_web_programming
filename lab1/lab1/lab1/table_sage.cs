//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab1
{
    using System;
    using System.Collections.Generic;
    
    public partial class table_sage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public table_sage()
        {
            this.table_sage_book = new HashSet<table_sage_book>();
        }
    
        public int sageId { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public string city { get; set; }
        public string photo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<table_sage_book> table_sage_book { get; set; }
    }
}