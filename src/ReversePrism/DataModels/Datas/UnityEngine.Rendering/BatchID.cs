using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Null                                     BatchID IL2CPP_TYPE_VALUETYPE
    // 010 Value                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class BatchID
    {
        public uint                                     Value                                   { get; set; }

        public static BatchID? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchID();

            value.Value                                     = GetUInt32(new IntPtr(p + 0x010)); // 02700244F1F8 0x10 Value                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
