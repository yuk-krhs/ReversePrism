using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 LeftTop                                  0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 038 RightTop                                 0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 040 LeftBottom                               0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 048 RightBottom                              0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 050 BlendType                                000186764C20 ModelClassType BlendTypeParameter BlendTypeParameter BlendTypeParameter Pointer
    // 000 vector4Array                             Vector4[] IL2CPP_TYPE_SZARRAY
    public partial class ScreenEdgeColor
    {
        public ColorParameter?                          LeftTop                                 { get; set; }
        public ColorParameter?                          RightTop                                { get; set; }
        public ColorParameter?                          LeftBottom                              { get; set; }
        public ColorParameter?                          RightBottom                             { get; set; }
        public BlendTypeParameter?                      BlendType                               { get; set; }

        public static ScreenEdgeColor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenEdgeColor();

            value.LeftTop                                   = GetObject<ColorParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.ColorParameter.FromPointer); // 0270061230F0 0x30 LeftTop                     ( 0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.RightTop                                  = GetObject<ColorParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ColorParameter.FromPointer); // 027006123110 0x38 RightTop                    ( 0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.LeftBottom                                = GetObject<ColorParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.ColorParameter.FromPointer); // 027006123130 0x40 LeftBottom                  ( 0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.RightBottom                               = GetObject<ColorParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.ColorParameter.FromPointer); // 027006123150 0x48 RightBottom                 ( 0001865D1170 ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.BlendType                                 = GetObject<BlendTypeParameter>(new IntPtr(p + 0x050), ReversePrism.DataModels.BlendTypeParameter.FromPointer); // 027006123170 0x50 BlendType                   ( 000186764C20 ModelClassType BlendTypeParameter BlendTypeParameter BlendTypeParameter Pointer )

            return value;
        }
    }
}
