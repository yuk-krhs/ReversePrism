using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventMaster                              ModelClassType MstEvent MstEvent MstEvent Pointer
    // 018 RankingMasters                           ModelClassListType IReadOnlyList`1<MstEventRanking> IReadOnlyList`1<MstEventRanking> List<MstEventRanking> Pointer
    // 020 RankingCategoryArray                     ModelEnumListType List`1<LiveEventRankingCategory> List`1<LiveEventRankingCategory> List<LiveEventRankingCategory> Pointer
    // 028 RewardCategoryArray                      ModelEnumListType List`1<LiveEventRewardCategory> List`1<LiveEventRewardCategory> List<LiveEventRewardCategory> Pointer
    // 030 SelectedFunctionIndex                    ModelPrimitiveType int int int Int32
    // 034 SelectedRewardIndex                      ModelPrimitiveType int int int Int32
    // 038 SelectedRankingIndex                     ModelPrimitiveType int int int Int32
    // 040 onChangeIndex                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 RankingCategoryOrderArray                ModelEnumListType LiveEventRankingCategory[] LiveEventRankingCategory[] List<LiveEventRankingCategory> Pointer
    // 050 SaveData                                 ModelClassType LiveEventSaveData LiveEventSaveData LiveEventSaveData Pointer
    public partial class LiveEventRankingViewModel : DataModel
    {
        public MstEvent?                                EventMaster                             { get; set; }
        public List<MstEventRanking>?                   RankingMasters                          { get; set; }
        public List<LiveEventRankingCategory>?          RankingCategoryArray                    { get; set; }
        public List<LiveEventRewardCategory>?           RewardCategoryArray                     { get; set; }
        public int                                      SelectedFunctionIndex                   { get; set; }
        public int                                      SelectedRewardIndex                     { get; set; }
        public int                                      SelectedRankingIndex                    { get; set; }
        public List<LiveEventRankingCategory>?          RankingCategoryOrderArray               { get; set; }
        public LiveEventSaveData?                       SaveData                                { get; set; }

        public static LiveEventRankingViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventRankingViewModel() { Pointer= p0 };

            value.EventMaster                               = GetObject<MstEvent>(new IntPtr(p + 0x010), ReversePrism.DataModels.MstEvent.FromPointer); // 0x10 EventMaster                 ( ModelClassType MstEvent MstEvent MstEvent Pointer )
            value.RankingMasters                            = GetObjectList<MstEventRanking>(new IntPtr(p + 0x018), ReversePrism.DataModels.MstEventRanking.FromPointer); // 0x18 RankingMasters              ( ModelClassListType IReadOnlyList`1<MstEventRanking> IReadOnlyList`1<MstEventRanking> List<MstEventRanking> Pointer )
            value.RankingCategoryArray                      = GetEnumList<LiveEventRankingCategory>(new IntPtr(p + 0x020)); // 0x20 RankingCategoryArray        ( ModelEnumListType List`1<LiveEventRankingCategory> List`1<LiveEventRankingCategory> List<LiveEventRankingCategory> Pointer )
            value.RewardCategoryArray                       = GetEnumList<LiveEventRewardCategory>(new IntPtr(p + 0x028)); // 0x28 RewardCategoryArray         ( ModelEnumListType List`1<LiveEventRewardCategory> List`1<LiveEventRewardCategory> List<LiveEventRewardCategory> Pointer )
            value.SelectedFunctionIndex                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 SelectedFunctionIndex       ( ModelPrimitiveType int int int Int32 )
            value.SelectedRewardIndex                       = GetInt32(new IntPtr(p + 0x034)); // 0x34 SelectedRewardIndex         ( ModelPrimitiveType int int int Int32 )
            value.SelectedRankingIndex                      = GetInt32(new IntPtr(p + 0x038)); // 0x38 SelectedRankingIndex        ( ModelPrimitiveType int int int Int32 )
            value.RankingCategoryOrderArray                 = GetEnumList<LiveEventRankingCategory>(new IntPtr(p + 0x048)); // 0x48 RankingCategoryOrderArray   ( ModelEnumListType LiveEventRankingCategory[] LiveEventRankingCategory[] List<LiveEventRankingCategory> Pointer )
            value.SaveData                                  = GetObject<LiveEventSaveData>(new IntPtr(p + 0x050), ReversePrism.DataModels.LiveEventSaveData.FromPointer); // 0x50 SaveData                    ( ModelClassType LiveEventSaveData LiveEventSaveData LiveEventSaveData Pointer )

            return value;
        }
    }
}
