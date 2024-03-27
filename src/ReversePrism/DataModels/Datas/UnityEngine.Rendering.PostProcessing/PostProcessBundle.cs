using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Attribute                                000186769DA0 ModelClassType PostProcessAttribute PostProcessAttribute PostProcessAttribute Pointer
    // 018 Settings                                 00018676B100 ModelClassType PostProcessEffectSettings PostProcessEffectSettings PostProcessEffectSettings Pointer
    // 020 M_Renderer                               00018676A820 ModelClassType PostProcessEffectRenderer PostProcessEffectRenderer PostProcessEffectRenderer Pointer
    public partial class PostProcessBundle
    {
        public PostProcessAttribute?                    Attribute                               { get; set; }
        public PostProcessEffectSettings?               Settings                                { get; set; }
        public PostProcessEffectRenderer?               M_Renderer                              { get; set; }

        public static PostProcessBundle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessBundle();

            value.Attribute                                 = GetObject<PostProcessAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.PostProcessAttribute.FromPointer); // 0270065ACB08 0x10 Attribute                   ( 000186769DA0 ModelClassType PostProcessAttribute PostProcessAttribute PostProcessAttribute Pointer )
            value.Settings                                  = GetObject<PostProcessEffectSettings>(new IntPtr(p + 0x018), ReversePrism.DataModels.PostProcessEffectSettings.FromPointer); // 0270065ACB28 0x18 Settings                    ( 00018676B100 ModelClassType PostProcessEffectSettings PostProcessEffectSettings PostProcessEffectSettings Pointer )
            value.M_Renderer                                = GetObject<PostProcessEffectRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.PostProcessEffectRenderer.FromPointer); // 0270065ACB48 0x20 M_Renderer                  ( 00018676A820 ModelClassType PostProcessEffectRenderer PostProcessEffectRenderer PostProcessEffectRenderer Pointer )

            return value;
        }
    }
}
