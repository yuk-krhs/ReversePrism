using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DwFileAttributes                         0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 FtCreationTime                           00018652BAD0 ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32
    // 01C FtLastAccessTime                         00018652BAD0 ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32
    // 024 FtLastWriteTime                          00018652BAD0 ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32
    // 02C NFileSizeHigh                            000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 030 NFileSizeLow                             000186698DF0 ModelPrimitiveType uint uint uint UInt32
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

            value.DwFileAttributes                          = GetInt32(new IntPtr(p + 0x010)); // 0245A3D02C68 0x10 DwFileAttributes            ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.FtCreationTime                            = (FILE_TIME)GetInt32(new IntPtr(p + 0x014)); // 0245A3D02C88 0x14 FtCreationTime              ( 00018652BAD0 ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32 )
            value.FtLastAccessTime                          = (FILE_TIME)GetInt32(new IntPtr(p + 0x01C)); // 0245A3D02CA8 0x1C FtLastAccessTime            ( 00018652BAD0 ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32 )
            value.FtLastWriteTime                           = (FILE_TIME)GetInt32(new IntPtr(p + 0x024)); // 0245A3D02CC8 0x24 FtLastWriteTime             ( 00018652BAD0 ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32 )
            value.NFileSizeHigh                             = GetUInt32(new IntPtr(p + 0x02C)); // 0245A3D02CE8 0x2C NFileSizeHigh               ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.NFileSizeLow                              = GetUInt32(new IntPtr(p + 0x030)); // 0245A3D02D08 0x30 NFileSizeLow                ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
