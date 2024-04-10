using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Min                                      0001866C6DB0 ModelEnumType float3 float3 float3 Int32
    // 01C Max                                      0001866C6DB0 ModelEnumType float3 float3 float3 Int32
    public partial class MinMaxAABB : DataModel
    {
        public float3                                   Min                                     { get; set; }
        public float3                                   Max                                     { get; set; }

        public static MinMaxAABB? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MinMaxAABB() { Pointer= p0 };

            value.Min                                       = (float3)GetInt32(new IntPtr(p + 0x010)); // 024667F0D990 0x10 Min                         ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )
            value.Max                                       = (float3)GetInt32(new IntPtr(p + 0x01C)); // 024667F0D9B0 0x1C Max                         ( 0001866C6DB0 ModelEnumType float3 float3 float3 Int32 )

            return value;
        }
    }
}
