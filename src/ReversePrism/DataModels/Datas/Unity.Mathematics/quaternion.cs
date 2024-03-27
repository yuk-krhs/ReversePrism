using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    0001866C7C90 ModelEnumType float4 float4 float4 Int32
    // 000 identity                                 quaternion IL2CPP_TYPE_VALUETYPE
    public partial class quaternion
    {
        public float4                                   Value                                   { get; set; }

        public static quaternion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new quaternion();

            value.Value                                     = (float4)GetInt32(new IntPtr(p + 0x010)); // 0270015CBE20 0x10 Value                       ( 0001866C7C90 ModelEnumType float4 float4 float4 Int32 )

            return value;
        }
    }
}
