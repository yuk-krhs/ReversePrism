using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ModelPrimitiveType ushort ushort ushort UInt16
    public partial class ExBitFlag16 : DataModel
    {
        public ushort                                   Value                                   { get; set; }

        public static ExBitFlag16? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExBitFlag16() { Pointer= p0 };

            value.Value                                     = GetUInt16(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
