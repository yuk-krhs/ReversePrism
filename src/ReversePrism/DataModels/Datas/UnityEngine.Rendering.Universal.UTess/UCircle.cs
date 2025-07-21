using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Center                                   ModelEnumType float2 float2 float2 Int32
    // 018 Radius                                   ModelPrimitiveType float float float Single
    public partial class UCircle : DataModel
    {
        public float2                                   Center                                  { get; set; }
        public float                                    Radius                                  { get; set; }

        public static UCircle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UCircle() { Pointer= p0 };

            value.Center                                    = (float2)GetInt32(new IntPtr(p + 0x010)); // 0x10 Center                      ( ModelEnumType float2 float2 float2 Int32 )
            value.Radius                                    = GetSingle(new IntPtr(p + 0x018)); // 0x18 Radius                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
