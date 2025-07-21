using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     ModelPrimitiveType ushort ushort ushort UInt16
    public partial class BitArray16 : DataModel
    {
        public ushort                                   Data                                    { get; set; }

        public static BitArray16? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitArray16() { Pointer= p0 };

            value.Data                                      = GetUInt16(new IntPtr(p + 0x010)); // 0x10 Data                        ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
