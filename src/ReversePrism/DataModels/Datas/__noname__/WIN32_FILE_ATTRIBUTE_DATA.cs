using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DwFileAttributes                         ModelPrimitiveType int int int Int32
    // 014 FtCreationTime                           ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32
    // 01C FtLastAccessTime                         ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32
    // 024 FtLastWriteTime                          ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32
    // 02C NFileSizeHigh                            ModelPrimitiveType uint uint uint UInt32
    // 030 NFileSizeLow                             ModelPrimitiveType uint uint uint UInt32
    public partial class WIN32_FILE_ATTRIBUTE_DATA : DataModel
    {
        public int                                      DwFileAttributes                        { get; set; }
        public FILE_TIME                                FtCreationTime                          { get; set; }
        public FILE_TIME                                FtLastAccessTime                        { get; set; }
        public FILE_TIME                                FtLastWriteTime                         { get; set; }
        public uint                                     NFileSizeHigh                           { get; set; }
        public uint                                     NFileSizeLow                            { get; set; }

        public static WIN32_FILE_ATTRIBUTE_DATA? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WIN32_FILE_ATTRIBUTE_DATA() { Pointer= p0 };

            value.DwFileAttributes                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 DwFileAttributes            ( ModelPrimitiveType int int int Int32 )
            value.FtCreationTime                            = (FILE_TIME)GetInt32(new IntPtr(p + 0x014)); // 0x14 FtCreationTime              ( ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32 )
            value.FtLastAccessTime                          = (FILE_TIME)GetInt32(new IntPtr(p + 0x01C)); // 0x1C FtLastAccessTime            ( ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32 )
            value.FtLastWriteTime                           = (FILE_TIME)GetInt32(new IntPtr(p + 0x024)); // 0x24 FtLastWriteTime             ( ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32 )
            value.NFileSizeHigh                             = GetUInt32(new IntPtr(p + 0x02C)); // 0x2C NFileSizeHigh               ( ModelPrimitiveType uint uint uint UInt32 )
            value.NFileSizeLow                              = GetUInt32(new IntPtr(p + 0x030)); // 0x30 NFileSizeLow                ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
