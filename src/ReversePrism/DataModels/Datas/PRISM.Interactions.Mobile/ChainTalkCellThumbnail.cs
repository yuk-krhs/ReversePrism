using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Thumbnail                                ModelClassType MobileThumbnail MobileThumbnail MobileThumbnail Pointer
    // 028 Data                                     ModelClassType ChainTalkCellThumbnailData ChainTalkCellThumbnailData ChainTalkCellThumbnailData Pointer
    public partial class ChainTalkCellThumbnail : DataModel
    {
        public MobileThumbnail?                         Thumbnail                               { get; set; }
        public ChainTalkCellThumbnailData?              Data                                    { get; set; }

        public static ChainTalkCellThumbnail? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellThumbnail() { Pointer= p0 };

            value.Thumbnail                                 = GetObject<MobileThumbnail>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileThumbnail.FromPointer); // 0x20 Thumbnail                   ( ModelClassType MobileThumbnail MobileThumbnail MobileThumbnail Pointer )
            value.Data                                      = GetObject<ChainTalkCellThumbnailData>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChainTalkCellThumbnailData.FromPointer); // 0x28 Data                        ( ModelClassType ChainTalkCellThumbnailData ChainTalkCellThumbnailData ChainTalkCellThumbnailData Pointer )

            return value;
        }
    }
}
