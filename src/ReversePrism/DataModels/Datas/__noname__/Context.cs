using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ReadByteIndex                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 M_BitIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 M_BitBuffer                              00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    // 020 M_FailedReads                            0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Context
    {
        public int                                      M_ReadByteIndex                         { get; set; }
        public int                                      M_BitIndex                              { get; set; }
        public ulong                                    M_BitBuffer                             { get; set; }
        public int                                      M_FailedReads                           { get; set; }

        public static Context? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Context();

            value.M_ReadByteIndex                           = GetInt32(new IntPtr(p + 0x010)); // 02700526A348 0x10 M_ReadByteIndex             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.M_BitIndex                                = GetInt32(new IntPtr(p + 0x014)); // 02700526A368 0x14 M_BitIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.M_BitBuffer                               = GetUInt64(new IntPtr(p + 0x018)); // 02700526A388 0x18 M_BitBuffer                 ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_FailedReads                             = GetInt32(new IntPtr(p + 0x020)); // 02700526A3A8 0x20 M_FailedReads               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
