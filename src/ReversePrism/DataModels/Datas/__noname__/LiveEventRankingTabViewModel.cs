using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PointProduct                             ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 018 TargetMusicMaster                        ModelClassType MstSong MstSong MstSong Pointer
    // 020 EventId                                  ModelPrimitiveType int int int Int32
    // 024 RankingType                              ModelEnumType EventRankingType EventRankingType EventRankingType Int32
    // 028 ViewType                                 ModelEnumType EventRankingViewType EventRankingViewType EventRankingViewType Int32
    // 030 Comment                                  ModelPrimitiveType string string string String
    public partial class LiveEventRankingTabViewModel : DataModel
    {
        public IProductStatus?                          PointProduct                            { get; set; }
        public MstSong?                                 TargetMusicMaster                       { get; set; }
        public int                                      EventId                                 { get; set; }
        public EventRankingType                         RankingType                             { get; set; }
        public EventRankingViewType                     ViewType                                { get; set; }
        public string                                   Comment                                 { get; set; }

        public static LiveEventRankingTabViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingTabViewModel() { Pointer= p0 };

            value.PointProduct                              = GetObject<IProductStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x10 PointProduct                ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.TargetMusicMaster                         = GetObject<MstSong>(new IntPtr(p + 0x018), ReversePrism.DataModels.MstSong.FromPointer); // 0x18 TargetMusicMaster           ( ModelClassType MstSong MstSong MstSong Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 EventId                     ( ModelPrimitiveType int int int Int32 )
            value.RankingType                               = (EventRankingType)GetInt32(new IntPtr(p + 0x024)); // 0x24 RankingType                 ( ModelEnumType EventRankingType EventRankingType EventRankingType Int32 )
            value.ViewType                                  = (EventRankingViewType)GetInt32(new IntPtr(p + 0x028)); // 0x28 ViewType                    ( ModelEnumType EventRankingViewType EventRankingViewType EventRankingViewType Int32 )
            value.Comment                                   = GetString(new IntPtr(p + 0x030)); // 0x30 Comment                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
