using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentPos                               ModelClassType Transform Transform Transform Pointer
    // 028 Balloon                                  ModelClassType ChainTalkCellBalloon ChainTalkCellBalloon ChainTalkCellBalloon Pointer
    // 030 Stamp                                    ModelClassType ChainTalkCellStamp ChainTalkCellStamp ChainTalkCellStamp Pointer
    // 038 Thumbnail                                ModelClassType ChainTalkCellThumbnail ChainTalkCellThumbnail ChainTalkCellThumbnail Pointer
    public partial class ChainTalkCellContentContainer : DataModel
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
            var value   = new ChainTalkCellContentContainer() { Pointer= p0 };

            value.ContentPos                                = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 ContentPos                  ( ModelClassType Transform Transform Transform Pointer )
            value.Balloon                                   = GetObject<ChainTalkCellBalloon>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChainTalkCellBalloon.FromPointer); // 0x28 Balloon                     ( ModelClassType ChainTalkCellBalloon ChainTalkCellBalloon ChainTalkCellBalloon Pointer )
            value.Stamp                                     = GetObject<ChainTalkCellStamp>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChainTalkCellStamp.FromPointer); // 0x30 Stamp                       ( ModelClassType ChainTalkCellStamp ChainTalkCellStamp ChainTalkCellStamp Pointer )
            value.Thumbnail                                 = GetObject<ChainTalkCellThumbnail>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainTalkCellThumbnail.FromPointer); // 0x38 Thumbnail                   ( ModelClassType ChainTalkCellThumbnail ChainTalkCellThumbnail ChainTalkCellThumbnail Pointer )

            return value;
        }
    }
}
