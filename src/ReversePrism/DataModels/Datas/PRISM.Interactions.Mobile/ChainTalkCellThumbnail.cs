using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Image                                    0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 Data                                     00018655F7A0 ModelClassType ChainTalkCellThumbnailData ChainTalkCellThumbnailData ChainTalkCellThumbnailData Pointer
    public partial class ChainTalkCellThumbnail
    {
        public UIImage?                                 Image                                   { get; set; }
        public UIButton?                                Button                                  { get; set; }
        public ChainTalkCellThumbnailData?              Data                                    { get; set; }

        public static ChainTalkCellThumbnail? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellThumbnail();

            value.Image                                     = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB0E54D8 0x20 Image                       ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB0E54F8 0x28 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Data                                      = GetObject<ChainTalkCellThumbnailData>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChainTalkCellThumbnailData.FromPointer); // 0270DB0E5518 0x30 Data                        ( 00018655F7A0 ModelClassType ChainTalkCellThumbnailData ChainTalkCellThumbnailData ChainTalkCellThumbnailData Pointer )

            return value;
        }
    }
}
