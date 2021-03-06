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
    
    public partial class FormDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormDetails()
        {
            this.MaterialEstimation = new HashSet<MaterialEstimation>();
            this.PurchasingOrder = new HashSet<PurchasingOrder>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> FormId { get; set; }
        public string DemandUnit { get; set; }
        public string FormNumber { get; set; }
        public int BatchNumber { get; set; }
        public Nullable<System.DateTime> ExpectedDelivery { get; set; }
        public Nullable<System.DateTime> ActualDelivery { get; set; }
        public System.DateTime MakingFormDate { get; set; }
        public System.Guid MakingUserId { get; set; }
        public Nullable<System.Guid> ManufacturersId { get; set; }
        public Nullable<double> ReservedPercentage { get; set; }
        public string ReservedField1 { get; set; }
        public string ReservedField2 { get; set; }
        public string ReservedField3 { get; set; }
        public string ReservedField4 { get; set; }
        public string ReservedField5 { get; set; }
        public string ReservedField6 { get; set; }
        public string ReservedField7 { get; set; }
        public string ReservedField8 { get; set; }
        public string ReservedField9 { get; set; }
        public string ReservedField10 { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.Guid CreateUserId { get; set; }
    
        public virtual Forms Forms { get; set; }
        public virtual Manufacturers Manufacturers { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialEstimation> MaterialEstimation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchasingOrder> PurchasingOrder { get; set; }
    }
}
