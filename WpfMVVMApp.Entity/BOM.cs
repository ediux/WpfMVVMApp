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
    
    public partial class BOM
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> ProcessingAtlasId { get; set; }
        public string Name { get; set; }
        public string CombinationNumber { get; set; }
        public System.Guid MaterialCategoriesId { get; set; }
        public string ProcessingNumber { get; set; }
        public string CrowdedNumber { get; set; }
        public string MaterialDescription { get; set; }
        public string CutLength { get; set; }
        public Nullable<decimal> SingleNumber { get; set; }
        public string Unit { get; set; }
        public decimal TotalDemand { get; set; }
        public Nullable<System.Guid> ShopFlowId { get; set; }
        public Nullable<int> NorthTowerDemand { get; set; }
        public Nullable<int> SouthTowerDemand { get; set; }
        public string Comment { get; set; }
        public string Postion { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.Guid CreateUserId { get; set; }
    
        public virtual MaterialCategories MaterialCategories { get; set; }
        public virtual ProcessingAtlas ProcessingAtlas { get; set; }
        public virtual ShopFlow ShopFlow { get; set; }
        public virtual Users Users { get; set; }
    }
}