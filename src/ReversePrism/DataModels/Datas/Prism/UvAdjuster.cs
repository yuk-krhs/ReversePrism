using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScaleRate                                0001866656B0 ModelPrimitiveType float float float Single
    // 028 RawImage                                 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    public partial class UvAdjuster
    {
        public float                                    ScaleRate                               { get; set; }
        public UIRawImage?                              RawImage                                { get; set; }

        public static UvAdjuster? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UvAdjuster();

            value.ScaleRate                                 = GetSingle(new IntPtr(p + 0x020)); // 0270D4D1FB30 0x20 ScaleRate                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.RawImage                                  = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D4D1FB50 0x28 RawImage                    ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )

            return value;
        }
    }
}
