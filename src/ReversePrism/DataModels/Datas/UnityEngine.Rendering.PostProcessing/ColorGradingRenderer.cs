using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_GradingCurves                          000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 028 M_Pixels                                 000185B75B80 ModelEnumListType Color[] Color[] List<Color> Pointer
    // 030 M_InternalLdrLut                         000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 038 M_InternalLogLut                         000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 000 k_Lut2DSize                              int IL2CPP_TYPE_I4
    // 000 k_Lut3DSize                              int IL2CPP_TYPE_I4
    // 040 M_HableCurve                             0001866A52B0 ModelClassType HableCurve HableCurve HableCurve Pointer
    public partial class ColorGradingRenderer : DataModel
    {
        public Texture2D?                               M_GradingCurves                         { get; set; }
        public List<Color>?                             M_Pixels                                { get; set; }
        public RenderTexture?                           M_InternalLdrLut                        { get; set; }
        public RenderTexture?                           M_InternalLogLut                        { get; set; }
        public HableCurve?                              M_HableCurve                            { get; set; }

        public static ColorGradingRenderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorGradingRenderer() { Pointer= p0 };

            value.M_GradingCurves                           = GetObject<Texture2D>(new IntPtr(p + 0x020), ReversePrism.DataModels.Texture2D.FromPointer); // 0245A6550510 0x20 M_GradingCurves             ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_Pixels                                  = GetEnumList<Color>(new IntPtr(p + 0x028)); // 0245A6550530 0x28 M_Pixels                    ( 000185B75B80 ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.M_InternalLdrLut                          = GetObject<RenderTexture>(new IntPtr(p + 0x030), ReversePrism.DataModels.RenderTexture.FromPointer); // 0245A6550550 0x30 M_InternalLdrLut            ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.M_InternalLogLut                          = GetObject<RenderTexture>(new IntPtr(p + 0x038), ReversePrism.DataModels.RenderTexture.FromPointer); // 0245A6550570 0x38 M_InternalLogLut            ( 000186655F80 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.M_HableCurve                              = GetObject<HableCurve>(new IntPtr(p + 0x040), ReversePrism.DataModels.HableCurve.FromPointer); // 0245A65505D0 0x40 M_HableCurve                ( 0001866A52B0 ModelClassType HableCurve HableCurve HableCurve Pointer )

            return value;
        }
    }
}
