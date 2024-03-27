using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentPos                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 Balloon                                  00018655B110 ModelClassType ChainTalkCellBalloon ChainTalkCellBalloon ChainTalkCellBalloon Pointer
    // 030 Stamp                                    00018655E880 ModelClassType ChainTalkCellStamp ChainTalkCellStamp ChainTalkCellStamp Pointer
    // 038 Thumbnail                                00018655F290 ModelClassType ChainTalkCellThumbnail ChainTalkCellThumbnail ChainTalkCellThumbnail Pointer
    public partial class ChainTalkCellContentContainer
    {
        public Transform?                               ContentPos                              { get; set; }
        public ChainTalkCellBalloon?                    Balloon                                 { get; set; }
        public ChainTalkCellStamp?                      Stamp                                   { get; set; }
        public ChainTalkCellThumbnail?                  Thumbnail                               { get; set; }

        public static ChainTalkCellContentContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellContentContainer();

            value.ContentPos                                = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0270DB0E5210 0x20 ContentPos                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Balloon                                   = GetObject<ChainTalkCellBalloon>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChainTalkCellBalloon.FromPointer); // 0270DB0E5230 0x28 Balloon                     ( 00018655B110 ModelClassType ChainTalkCellBalloon ChainTalkCellBalloon ChainTalkCellBalloon Pointer )
            value.Stamp                                     = GetObject<ChainTalkCellStamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChainTalkCellStamp.FromPointer); // 0270DB0E5250 0x30 Stamp                       ( 00018655E880 ModelClassType ChainTalkCellStamp ChainTalkCellStamp ChainTalkCellStamp Pointer )
            value.Thumbnail                                 = GetObject<ChainTalkCellThumbnail>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainTalkCellThumbnail.FromPointer); // 0270DB0E5270 0x38 Thumbnail                   ( 00018655F290 ModelClassType ChainTalkCellThumbnail ChainTalkCellThumbnail ChainTalkCellThumbnail Pointer )

            return value;
        }
    }
}
