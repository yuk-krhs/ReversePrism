using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Attribute                                ModelClassType PostProcessAttribute PostProcessAttribute PostProcessAttribute Pointer
    // 018 Settings                                 ModelClassType PostProcessEffectSettings PostProcessEffectSettings PostProcessEffectSettings Pointer
    // 020 M_Renderer                               ModelClassType PostProcessEffectRenderer PostProcessEffectRenderer PostProcessEffectRenderer Pointer
    public partial class PostProcessBundle : DataModel
    {
        public PostProcessAttribute?                    Attribute                               { get; set; }
        public PostProcessEffectSettings?               Settings                                { get; set; }
        public PostProcessEffectRenderer?               M_Renderer                              { get; set; }

        public static PostProcessBundle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessBundle() { Pointer= p0 };

            value.Attribute                                 = GetObject<PostProcessAttribute>(new IntPtr(p + 0x010), ReversePrism.DataModels.PostProcessAttribute.FromPointer); // 0x10 Attribute                   ( ModelClassType PostProcessAttribute PostProcessAttribute PostProcessAttribute Pointer )
            value.Settings                                  = GetObject<PostProcessEffectSettings>(new IntPtr(p + 0x018), ReversePrism.DataModels.PostProcessEffectSettings.FromPointer); // 0x18 Settings                    ( ModelClassType PostProcessEffectSettings PostProcessEffectSettings PostProcessEffectSettings Pointer )
            value.M_Renderer                                = GetObject<PostProcessEffectRenderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.PostProcessEffectRenderer.FromPointer); // 0x20 M_Renderer                  ( ModelClassType PostProcessEffectRenderer PostProcessEffectRenderer PostProcessEffectRenderer Pointer )

            return value;
        }
    }
}
