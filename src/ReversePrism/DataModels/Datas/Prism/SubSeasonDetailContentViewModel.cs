using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ConditionDetailList                      ModelClassListType List`1<ConditionDetail> List`1<ConditionDetail> List<ConditionDetail> Pointer
    // 018 ConditionList                            ModelClassListType IReadOnlyList`1<ISubSeasonConditionStatus> IReadOnlyList`1<ISubSeasonConditionStatus> List<ISubSeasonConditionStatus> Pointer
    // 020 SelectedSubSeasonIdList                  ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 028 SelectedSubSeasonNumList                 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 030 NowSeason                                ModelPrimitiveType int int int Int32
    public partial class SubSeasonDetailContentViewModel : DataModel
    {
        public List<ConditionDetail>?                   ConditionDetailList                     { get; set; }
        public List<ISubSeasonConditionStatus>?         ConditionList                           { get; set; }
        public List<int>?                               SelectedSubSeasonIdList                 { get; set; }
        public List<int>?                               SelectedSubSeasonNumList                { get; set; }
        public int                                      NowSeason                               { get; set; }

        public static SubSeasonDetailContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonDetailContentViewModel() { Pointer= p0 };

            value.ConditionDetailList                       = GetObjectList<ConditionDetail>(new IntPtr(p + 0x010), ReversePrism.DataModels.ConditionDetail.FromPointer); // 0x10 ConditionDetailList         ( ModelClassListType List`1<ConditionDetail> List`1<ConditionDetail> List<ConditionDetail> Pointer )
            value.ConditionList                             = GetObjectList<ISubSeasonConditionStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISubSeasonConditionStatus.FromPointer); // 0x18 ConditionList               ( ModelClassListType IReadOnlyList`1<ISubSeasonConditionStatus> IReadOnlyList`1<ISubSeasonConditionStatus> List<ISubSeasonConditionStatus> Pointer )
            value.SelectedSubSeasonIdList                   = GetInt32List(new IntPtr(p + 0x020)); // 0x20 SelectedSubSeasonIdList     ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.SelectedSubSeasonNumList                  = GetInt32List(new IntPtr(p + 0x028)); // 0x28 SelectedSubSeasonNumList    ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.NowSeason                                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 NowSeason                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
