using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Image                                    0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    public partial class ChainTalkCellStamp
    {
        public UIImage?                                 Image                                   { get; set; }

        public static ChainTalkCellStamp? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellStamp();

            value.Image                                     = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB0E54B8 0x20 Image                       ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
