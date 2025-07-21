using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  ModelPrimitiveType int int int Int32
    // 018 TargetMusicMaster                        ModelClassType MstSong MstSong MstSong Pointer
    // 020 PointProduct                             ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 028 ViewType                                 ModelEnumType LiveEventAllSongRankingViewType LiveEventAllSongRankingViewType LiveEventAllSongRankingViewType Int32
    // 030 Comment                                  ModelPrimitiveType string string string String
    // 038 IdolIds                                  ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 040 Rankings                                 ModelClassListType IReadOnlyList`1<MstEventRanking> IReadOnlyList`1<MstEventRanking> List<MstEventRanking> Pointer
    // 048 RankingType                              ModelEnumType EventRankingType EventRankingType EventRankingType Int32
    // 050 saveData                                 SavableJsonObject`1<LiveEventSaveData> IL2CPP_TYPE_GENERICINST
    public partial class LiveEventAllSongRankingTabViewModel : DataModel
    {
        public int                                      EventId                                 { get; set; }
        public MstSong?                                 TargetMusicMaster                       { get; set; }
        public IProductStatus?                          PointProduct                            { get; set; }
        public LiveEventAllSongRankingViewType          ViewType                                { get; set; }
        public string                                   Comment                                 { get; set; }
        public List<int>?                               IdolIds                                 { get; set; }
        public List<MstEventRanking>?                   Rankings                                { get; set; }
        public EventRankingType                         RankingType                             { get; set; }

        public static LiveEventAllSongRankingTabViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventAllSongRankingTabViewModel() { Pointer= p0 };

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 EventId                     ( ModelPrimitiveType int int int Int32 )
            value.TargetMusicMaster                         = GetObject<MstSong>(new IntPtr(p + 0x018), ReversePrism.DataModels.MstSong.FromPointer); // 0x18 TargetMusicMaster           ( ModelClassType MstSong MstSong MstSong Pointer )
            value.PointProduct                              = GetObject<IProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x20 PointProduct                ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.ViewType                                  = (LiveEventAllSongRankingViewType)GetInt32(new IntPtr(p + 0x028)); // 0x28 ViewType                    ( ModelEnumType LiveEventAllSongRankingViewType LiveEventAllSongRankingViewType LiveEventAllSongRankingViewType Int32 )
            value.Comment                                   = GetString(new IntPtr(p + 0x030)); // 0x30 Comment                     ( ModelPrimitiveType string string string String )
            value.IdolIds                                   = GetInt32List(new IntPtr(p + 0x038)); // 0x38 IdolIds                     ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.Rankings                                  = GetObjectList<MstEventRanking>(new IntPtr(p + 0x040), ReversePrism.DataModels.MstEventRanking.FromPointer); // 0x40 Rankings                    ( ModelClassListType IReadOnlyList`1<MstEventRanking> IReadOnlyList`1<MstEventRanking> List<MstEventRanking> Pointer )
            value.RankingType                               = (EventRankingType)GetInt32(new IntPtr(p + 0x048)); // 0x48 RankingType                 ( ModelEnumType EventRankingType EventRankingType EventRankingType Int32 )

            return value;
        }
    }
}
