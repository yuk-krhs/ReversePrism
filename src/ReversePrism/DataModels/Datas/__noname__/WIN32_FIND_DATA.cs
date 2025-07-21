using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DwFileAttributes                         ModelPrimitiveType uint uint uint UInt32
    // 014 FtCreationTime                           ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32
    // 01C FtLastAccessTime                         ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32
    // 024 FtLastWriteTime                          ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32
    // 02C NFileSizeHigh                            ModelPrimitiveType uint uint uint UInt32
    // 030 NFileSizeLow                             ModelPrimitiveType uint uint uint UInt32
    // 034 DwReserved0                              ModelPrimitiveType uint uint uint UInt32
    // 038 DwReserved1                              ModelPrimitiveType uint uint uint UInt32
    // 03C CFileName                                ModelEnumType <_cFileName>e__FixedBuffer <_cFileName>e__FixedBuffer <_cFileName>e__FixedBuffer Int32
    // 244 CAlternateFileName                       ModelEnumType <_cAlternateFileName>e__FixedBuffer <_cAlternateFileName>e__FixedBuffer <_cAlternateFileName>e__FixedBuffer Int32
    public partial class WIN32_FIND_DATA : DataModel
    {
        public uint                                     DwFileAttributes                        { get; set; }
        public FILE_TIME                                FtCreationTime                          { get; set; }
        public FILE_TIME                                FtLastAccessTime                        { get; set; }
        public FILE_TIME                                FtLastWriteTime                         { get; set; }
        public uint                                     NFileSizeHigh                           { get; set; }
        public uint                                     NFileSizeLow                            { get; set; }
        public uint                                     DwReserved0                             { get; set; }
        public uint                                     DwReserved1                             { get; set; }
        public <_cFileName>e__FixedBuffer               CFileName                               { get; set; }
        public <_cAlternateFileName>e__FixedBuffer      CAlternateFileName                      { get; set; }

        public static WIN32_FIND_DATA? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WIN32_FIND_DATA() { Pointer= p0 };

            value.DwFileAttributes                          = GetUInt32(new IntPtr(p + 0x010)); // 0x10 DwFileAttributes            ( ModelPrimitiveType uint uint uint UInt32 )
            value.FtCreationTime                            = (FILE_TIME)GetInt32(new IntPtr(p + 0x014)); // 0x14 FtCreationTime              ( ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32 )
            value.FtLastAccessTime                          = (FILE_TIME)GetInt32(new IntPtr(p + 0x01C)); // 0x1C FtLastAccessTime            ( ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32 )
            value.FtLastWriteTime                           = (FILE_TIME)GetInt32(new IntPtr(p + 0x024)); // 0x24 FtLastWriteTime             ( ModelEnumType FILE_TIME FILE_TIME FILE_TIME Int32 )
            value.NFileSizeHigh                             = GetUInt32(new IntPtr(p + 0x02C)); // 0x2C NFileSizeHigh               ( ModelPrimitiveType uint uint uint UInt32 )
            value.NFileSizeLow                              = GetUInt32(new IntPtr(p + 0x030)); // 0x30 NFileSizeLow                ( ModelPrimitiveType uint uint uint UInt32 )
            value.DwReserved0                               = GetUInt32(new IntPtr(p + 0x034)); // 0x34 DwReserved0                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.DwReserved1                               = GetUInt32(new IntPtr(p + 0x038)); // 0x38 DwReserved1                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.CFileName                                 = (<_cFileName>e__FixedBuffer)GetInt32(new IntPtr(p + 0x03C)); // 0x3C CFileName                   ( ModelEnumType <_cFileName>e__FixedBuffer <_cFileName>e__FixedBuffer <_cFileName>e__FixedBuffer Int32 )
            value.CAlternateFileName                        = (<_cAlternateFileName>e__FixedBuffer)GetInt32(new IntPtr(p + 0x244)); // 0x244 CAlternateFileName          ( ModelEnumType <_cAlternateFileName>e__FixedBuffer <_cAlternateFileName>e__FixedBuffer <_cAlternateFileName>e__FixedBuffer Int32 )

            return value;
        }
    }
}
