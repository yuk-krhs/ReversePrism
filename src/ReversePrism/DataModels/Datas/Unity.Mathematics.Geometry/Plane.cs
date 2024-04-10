using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NormalAndDistance                        0001866C7C90 ModelEnumType float4 float4 float4 Int32
    public partial class Plane : DataModel
    {
        public float4                                   NormalAndDistance                       { get; set; }

        public static Plane? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Plane() { Pointer= p0 };

            value.NormalAndDistance                         = (float4)GetInt32(new IntPtr(p + 0x010)); // 024667F0E328 0x10 NormalAndDistance           ( 0001866C7C90 ModelEnumType float4 float4 float4 Int32 )

            return value;
        }
    }
}
