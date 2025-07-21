using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TalkTextType                             ModelEnumType PostType PostType PostType Int32
    // 014 TalkerType                               ModelEnumType TalkerType TalkerType TalkerType Int32
    // 018 HeaderData                               ModelClassType ChainTalkCellHeaderData ChainTalkCellHeaderData ChainTalkCellHeaderData Pointer
    // 020 BalloonData                              ModelClassType ChainTalkCellBalloonData ChainTalkCellBalloonData ChainTalkCellBalloonData Pointer
    // 028 StampData                                ModelClassType ChainTalkCellStampData ChainTalkCellStampData ChainTalkCellStampData Pointer
    // 030 ThumbnailData                            ModelClassType ChainTalkCellThumbnailData ChainTalkCellThumbnailData ChainTalkCellThumbnailData Pointer
    // 038 Node                                     ModelClassType ChainTalkNode ChainTalkNode ChainTalkNode Pointer
    public partial class ChainTalkCellCommonData : DataModel
    {
        public PostType                                 TalkTextType                            { get; set; }
        public TalkerType                               TalkerType                              { get; set; }
        public ChainTalkCellHeaderData?                 HeaderData                              { get; set; }
        public ChainTalkCellBalloonData?                BalloonData                             { get; set; }
        public ChainTalkCellStampData?                  StampData                               { get; set; }
        public ChainTalkCellThumbnailData?              ThumbnailData                           { get; set; }
        public ChainTalkNode?                           Node                                    { get; set; }

        public static ChainTalkCellCommonData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkCellCommonData() { Pointer= p0 };

            value.TalkTextType                              = (PostType)GetInt32(new IntPtr(p + 0x010)); // 0x10 TalkTextType                ( ModelEnumType PostType PostType PostType Int32 )
            value.TalkerType                                = (TalkerType)GetInt32(new IntPtr(p + 0x014)); // 0x14 TalkerType                  ( ModelEnumType TalkerType TalkerType TalkerType Int32 )
            value.HeaderData                                = GetObject<ChainTalkCellHeaderData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChainTalkCellHeaderData.FromPointer); // 0x18 HeaderData                  ( ModelClassType ChainTalkCellHeaderData ChainTalkCellHeaderData ChainTalkCellHeaderData Pointer )
            value.BalloonData                               = GetObject<ChainTalkCellBalloonData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChainTalkCellBalloonData.FromPointer); // 0x20 BalloonData                 ( ModelClassType ChainTalkCellBalloonData ChainTalkCellBalloonData ChainTalkCellBalloonData Pointer )
            value.StampData                                 = GetObject<ChainTalkCellStampData>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChainTalkCellStampData.FromPointer); // 0x28 StampData                   ( ModelClassType ChainTalkCellStampData ChainTalkCellStampData ChainTalkCellStampData Pointer )
            value.ThumbnailData                             = GetObject<ChainTalkCellThumbnailData>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChainTalkCellThumbnailData.FromPointer); // 0x30 ThumbnailData               ( ModelClassType ChainTalkCellThumbnailData ChainTalkCellThumbnailData ChainTalkCellThumbnailData Pointer )
            value.Node                                      = GetObject<ChainTalkNode>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainTalkNode.FromPointer); // 0x38 Node                        ( ModelClassType ChainTalkNode ChainTalkNode ChainTalkNode Pointer )

            return value;
        }
    }
}
