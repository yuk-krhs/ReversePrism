using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Null                                     BatchMaterialID IL2CPP_TYPE_VALUETYPE
    // 010 Value                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class BatchMaterialID
    {
        public uint                                     Value                                   { get; set; }

        public static BatchMaterialID? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchMaterialID();

            value.Value                                     = GetUInt32(new IntPtr(p + 0x010)); // 027002450CA8 0x10 Value                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
