using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RawImage                                 000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 BlurRatio                                000186666050 ModelPrimitiveType float float float Single
    public partial class CameraDisplay
    {
        public RawImage?                                RawImage                                { get; set; }
        public float                                    BlurRatio                               { get; set; }

        public static CameraDisplay? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraDisplay();

            value.RawImage                                  = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0270D4DF7A50 0x20 RawImage                    ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.BlurRatio                                 = GetSingle(new IntPtr(p + 0x028)); // 0270D4DF7A70 0x28 BlurRatio                   ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
