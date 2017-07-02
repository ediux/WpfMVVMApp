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
    
    public partial class ProcessingAtlas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcessingAtlas()
        {
            this.BOM = new HashSet<BOM>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ProjectContractId { get; set; }
        public int Order { get; set; }
        public int Atlas { get; set; }
        public string Name { get; set; }
        public int UpdateTimes { get; set; }
        public Nullable<System.DateTime> ConstructionOrderChangeDate { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.Guid CreateUserId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOM> BOM { get; set; }
        public virtual ProjectContract ProjectContract { get; set; }
    }
}
