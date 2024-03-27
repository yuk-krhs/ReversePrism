using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_dataIndex                              0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 M_uiFamilyCodePage                       0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 M_webName                                000186671BA0 ModelPrimitiveType string string string String
    // 020 M_headerName                             000186671BA0 ModelPrimitiveType string string string String
    // 028 M_flags                                  000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 000 sep                                      char[] IL2CPP_TYPE_SZARRAY
    public partial class CodePageDataItem
    {
        public int                                      M_dataIndex                             { get; set; }
        public int                                      M_uiFamilyCodePage                      { get; set; }
        public string                                   M_webName                               { get; set; }
        public string                                   M_headerName                            { get; set; }
        public uint                                     M_flags                                 { get; set; }

        public static CodePageDataItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CodePageDataItem();

            value.M_dataIndex                               = GetInt32(new IntPtr(p + 0x010)); // 027004C2CBD8 0x10 M_dataIndex                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_uiFamilyCodePage                        = GetInt32(new IntPtr(p + 0x014)); // 027004C2CBF8 0x14 M_uiFamilyCodePage          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_webName                                 = GetString(new IntPtr(p + 0x018)); // 027004C2CC18 0x18 M_webName                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_headerName                              = GetString(new IntPtr(p + 0x020)); // 027004C2CC38 0x20 M_headerName                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_flags                                   = GetUInt32(new IntPtr(p + 0x028)); // 027004C2CC58 0x28 M_flags                     ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
