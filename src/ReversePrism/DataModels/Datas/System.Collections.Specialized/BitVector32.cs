using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     000186698B70 ModelPrimitiveType uint uint uint UInt32
    public partial class BitVector32 : DataModel
    {
        public uint                                     Data                                    { get; set; }

        public static BitVector32? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitVector32() { Pointer= p0 };

            value.Data                                      = GetUInt32(new IntPtr(p + 0x010)); // 024667B85608 0x10 Data                        ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
