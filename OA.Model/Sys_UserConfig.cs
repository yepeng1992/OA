//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sys_UserConfig
    {
        public string UserID { get; set; }
        public string Skin { get; set; }
        public Nullable<System.DateTime> LastOnlineTime { get; set; }
        public Nullable<int> TotalOnline { get; set; }
        public Nullable<System.DateTime> LogoutTime { get; set; }
        public Nullable<int> OnlineState { get; set; }
        public string NickName { get; set; }
        public string SignaTure { get; set; }
        public string OnlineIP { get; set; }
    }
}
