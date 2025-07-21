using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WorldToShadowMatrix                      ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 050 ShadowParams                             ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class ShadowData : DataModel
    {
        public Matrix4x4                                WorldToShadowMatrix                     { get; set; }
        public Vector4                                  ShadowParams                            { get; set; }

        public static ShadowData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShadowData() { Pointer= p0 };

            value.WorldToShadowMatrix                       = (Matrix4x4)GetInt32(new IntPtr(p + 0x010)); // 0x10 WorldToShadowMatrix         ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.ShadowParams                              = (Vector4)GetInt32(new IntPtr(p + 0x050)); // 0x50 ShadowParams                ( ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
