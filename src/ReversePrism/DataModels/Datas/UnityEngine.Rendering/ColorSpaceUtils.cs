using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Rec709ToRec2020Mat                       Matrix4x4 IL2CPP_TYPE_VALUETYPE
    // 040 Rec709ToP3D65Mat                         ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 080 Rec2020ToRec709Mat                       ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 0C0 Rec2020ToP3D65Mat                        ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 100 P3D65ToRec2020Mat                        ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    public partial class ColorSpaceUtils : DataModel
    {
        public Matrix4x4                                Rec709ToP3D65Mat                        { get; set; }
        public Matrix4x4                                Rec2020ToRec709Mat                      { get; set; }
        public Matrix4x4                                Rec2020ToP3D65Mat                       { get; set; }
        public Matrix4x4                                P3D65ToRec2020Mat                       { get; set; }

        public static ColorSpaceUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorSpaceUtils() { Pointer= p0 };

            value.Rec709ToP3D65Mat                          = (Matrix4x4)GetInt32(new IntPtr(p + 0x040)); // 0x40 Rec709ToP3D65Mat            ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Rec2020ToRec709Mat                        = (Matrix4x4)GetInt32(new IntPtr(p + 0x080)); // 0x80 Rec2020ToRec709Mat          ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Rec2020ToP3D65Mat                         = (Matrix4x4)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 Rec2020ToP3D65Mat           ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.P3D65ToRec2020Mat                         = (Matrix4x4)GetInt32(new IntPtr(p + 0x100)); // 0x100 P3D65ToRec2020Mat           ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )

            return value;
        }
    }
}
