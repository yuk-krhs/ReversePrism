using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PointProduct                             0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 018 TargetMusicMaster                        00018662BEA0 ModelClassType MstSong MstSong MstSong Pointer
    // 020 EventId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 024 RankingType                              0001865F1FD0 ModelEnumType EventRankingType EventRankingType EventRankingType Int32
    // 028 ViewType                                 0001865F2690 ModelEnumType EventRankingViewType EventRankingViewType EventRankingViewType Int32
    // 030 Comment                                  000186671910 ModelPrimitiveType string string string String
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

            value.PointProduct                              = GetObject<IProductStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductStatus.FromPointer); // 02466B997580 0x10 PointProduct                ( 0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.TargetMusicMaster                         = GetObject<MstSong>(new IntPtr(p + 0x018), ReversePrism.DataModels.MstSong.FromPointer); // 02466B9975A0 0x18 TargetMusicMaster           ( 00018662BEA0 ModelClassType MstSong MstSong MstSong Pointer )
            value.EventId                                   = GetInt32(new IntPtr(p + 0x020)); // 02466B9975C0 0x20 EventId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.RankingType                               = (EventRankingType)GetInt32(new IntPtr(p + 0x024)); // 02466B9975E0 0x24 RankingType                 ( 0001865F1FD0 ModelEnumType EventRankingType EventRankingType EventRankingType Int32 )
            value.ViewType                                  = (EventRankingViewType)GetInt32(new IntPtr(p + 0x028)); // 02466B997600 0x28 ViewType                    ( 0001865F2690 ModelEnumType EventRankingViewType EventRankingViewType EventRankingViewType Int32 )
            value.Comment                                   = GetString(new IntPtr(p + 0x030)); // 02466B997620 0x30 Comment                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
