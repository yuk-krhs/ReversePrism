using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DoubleImplicitBitIndex                   int IL2CPP_TYPE_I4
    // 000 SingleImplicitBitIndex                   int IL2CPP_TYPE_I4
    // 000 SignificandSize                          int IL2CPP_TYPE_I4
    // 010 F                                        00018669C740 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 E                                        0001865F4940 ModelPrimitiveType int int int Int32
    public partial class DiyFp : DataModel
    {
        public ulong                                    F                                       { get; set; }
        public int                                      E                                       { get; set; }

        public static DiyFp? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiyFp() { Pointer= p0 };

            value.F                                         = GetUInt64(new IntPtr(p + 0x010)); // 02466AB13C78 0x10 F                           ( 00018669C740 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.E                                         = GetInt32(new IntPtr(p + 0x018)); // 02466AB13C98 0x18 E                           ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
