﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Tokiku2_NewEntities : DbContext
    {
        public Tokiku2_NewEntities()
            : base("name=Tokiku2_NewEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccessLog> AccessLog { get; set; }
        public virtual DbSet<BOM> BOM { get; set; }
        public virtual DbSet<ConstructionAtlas> ConstructionAtlas { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Engineering> Engineering { get; set; }
        public virtual DbSet<FormDetails> FormDetails { get; set; }
        public virtual DbSet<Forms> Forms { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }
        public virtual DbSet<ManufacturersBussinessItems> ManufacturersBussinessItems { get; set; }
        public virtual DbSet<MaterialCategories> MaterialCategories { get; set; }
        public virtual DbSet<MaterialEstimation> MaterialEstimation { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Membership> Membership { get; set; }
        public virtual DbSet<Molds> Molds { get; set; }
        public virtual DbSet<MoldsInProjects> MoldsInProjects { get; set; }
        public virtual DbSet<MoldUseStatus> MoldUseStatus { get; set; }
        public virtual DbSet<PaymentTypes> PaymentTypes { get; set; }
        public virtual DbSet<ProcessingAtlas> ProcessingAtlas { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<ProjectContract> ProjectContract { get; set; }
        public virtual DbSet<ProjectItemCost> ProjectItemCost { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<PromissoryNoteManagement> PromissoryNoteManagement { get; set; }
        public virtual DbSet<PurchasingOrder> PurchasingOrder { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<ShopFlow> ShopFlow { get; set; }
        public virtual DbSet<ShopFlowDetail> ShopFlowDetail { get; set; }
        public virtual DbSet<ShopFlowHistory> ShopFlowHistory { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<SupplierTranscationItem> SupplierTranscationItem { get; set; }
        public virtual DbSet<TicketPeriod> TicketPeriod { get; set; }
        public virtual DbSet<TicketTypes> TicketTypes { get; set; }
        public virtual DbSet<TranscationCategories> TranscationCategories { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WorkShops> WorkShops { get; set; }
    }
}
