//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace final_0922
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetails
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int RoomID { get; set; }
        public decimal OrderPrice { get; set; }
        public Nullable<int> RoomDiscountID { get; set; }
        public System.DateTime OrderStartDate { get; set; }
        public System.DateTime OrderEndDate { get; set; }
        public int PayID { get; set; }
    
        public virtual Discount Discount { get; set; }
        public virtual Order Order { get; set; }
        public virtual Payment Payment { get; set; }
    }
}