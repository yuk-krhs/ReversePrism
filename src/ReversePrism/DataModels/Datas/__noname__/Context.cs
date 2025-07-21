using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ReadByteIndex                          ModelPrimitiveType int int int Int32
    // 014 M_BitIndex                               ModelPrimitiveType int int int Int32
    // 018 M_BitBuffer                              ModelPrimitiveType ulong ulong ulong UInt64
    // 020 M_FailedReads                            ModelPrimitiveType int int int Int32
    public partial class Context : DataModel
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
            var value   = new Context() { Pointer= p0 };

            value.M_ReadByteIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_ReadByteIndex             ( ModelPrimitiveType int int int Int32 )
            value.M_BitIndex                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_BitIndex                  ( ModelPrimitiveType int int int Int32 )
            value.M_BitBuffer                               = GetUInt64(new IntPtr(p + 0x018)); // 0x18 M_BitBuffer                 ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.M_FailedReads                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_FailedReads               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
