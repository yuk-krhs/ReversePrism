using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 UIFader IL2CPP_TYPE_CLASS
    // 020 <OnFadeInStartObservable>k__BackingField Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 028 <OnFadeInEndObservable>k__BackingField   Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 <OnFadeOutStartObservable>k__BackingField Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 <OnFadeOutEndObservable>k__BackingField  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 IsDark                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 FadeImage                                0001866CCDB0 ModelClassType Image Image Image Pointer
    // 008 BasicDarkColor                           Color32 IL2CPP_TYPE_VALUETYPE
    public partial class UIFader : DataModel
    {
        public bool                                     IsDark                                  { get; set; }
        public Image?                                   FadeImage                               { get; set; }

        public static UIFader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIFader() { Pointer= p0 };

            value.IsDark                                    = GetBool(new IntPtr(p + 0x040)); // 024660C759A0 0x40 IsDark                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FadeImage                                 = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 024660C759C0 0x48 FadeImage                   ( 0001866CCDB0 ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
