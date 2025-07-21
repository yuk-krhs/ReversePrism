using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 array                                    InlinedArray`1<ulong> IL2CPP_TYPE_GENERICINST
    // 028 Length                                   ModelPrimitiveType int int int Int32
    public partial class DynamicBitfield : DataModel
    {
        public int                                      Length                                  { get; set; }

        public static DynamicBitfield? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DynamicBitfield() { Pointer= p0 };

            value.Length                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 Length                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
