using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScaleRate                                ModelPrimitiveType float float float Single
    // 028 RawImage                                 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    public partial class UvAdjuster : DataModel
    {
        public float                                    ScaleRate                               { get; set; }
        public UIRawImage?                              RawImage                                { get; set; }

        public static UvAdjuster? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UvAdjuster() { Pointer= p0 };

            value.ScaleRate                                 = GetSingle(new IntPtr(p + 0x020)); // 0x20 ScaleRate                   ( ModelPrimitiveType float float float Single )
            value.RawImage                                  = GetObject<UIRawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x28 RawImage                    ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )

            return value;
        }
    }
}
