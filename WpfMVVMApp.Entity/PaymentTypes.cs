//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfMVVMApp.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentTypes()
        {
            this.Manufacturers = new HashSet<Manufacturers>();
            this.ManufacturersBussinessItems = new HashSet<ManufacturersBussinessItems>();
        }
    
        public byte Id { get; set; }
        public string PaymentTypeName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Manufacturers> Manufacturers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManufacturersBussinessItems> ManufacturersBussinessItems { get; set; }
    }
}
