using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Image                                    0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 ShowDuration                             0001866656B0 ModelPrimitiveType float float float Single
    // 02C HideDuration                             0001866656B0 ModelPrimitiveType float float float Single
    public partial class SimpleFadeLoadingContentView
    {
        public UIImage?                                 Image                                   { get; set; }
        public float                                    ShowDuration                            { get; set; }
        public float                                    HideDuration                            { get; set; }

        public static SimpleFadeLoadingContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimpleFadeLoadingContentView();

            value.Image                                     = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 027001E95798 0x20 Image                       ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.ShowDuration                              = GetSingle(new IntPtr(p + 0x028)); // 027001E957B8 0x28 ShowDuration                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.HideDuration                              = GetSingle(new IntPtr(p + 0x02C)); // 027001E957D8 0x2C HideDuration                ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
