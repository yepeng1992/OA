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
    
    public partial class Sys_Attachment
    {
        public string AttachmentID { get; set; }
        public string TableName { get; set; }
        public string Primarykey { get; set; }
        public string FileName { get; set; }
        public string RealName { get; set; }
        public Nullable<int> FileSize { get; set; }
        public string FileType { get; set; }
        public Nullable<System.DateTime> UpLoadTime { get; set; }
        public string SaveMark { get; set; }
        public Nullable<bool> DeleteMark { get; set; }
        public string FilePath { get; set; }
    }
}
