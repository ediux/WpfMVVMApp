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
    
    public partial class PromissoryNoteManagement
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> ProjectContractId { get; set; }
        public byte TicketTypeId { get; set; }
        public float Amount { get; set; }
        public System.DateTime OpenDate { get; set; }
        public Nullable<System.DateTime> RecoveryDate { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.Guid CreateUserId { get; set; }
    
        public virtual ProjectContract ProjectContract { get; set; }
        public virtual TicketTypes TicketTypes { get; set; }
        public virtual Users Users { get; set; }
    }
}