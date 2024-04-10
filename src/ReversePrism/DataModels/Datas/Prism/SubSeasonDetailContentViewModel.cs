using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ConditionDetailList                      000185D2C6A8 ModelClassListType List`1<ConditionDetail> List`1<ConditionDetail> List<ConditionDetail> Pointer
    // 018 ConditionList                            000185D0CF78 ModelClassListType IReadOnlyList`1<ISubSeasonConditionStatus> IReadOnlyList`1<ISubSeasonConditionStatus> List<ISubSeasonConditionStatus> Pointer
    // 020 SelectedSubSeasonIdList                  000185D11E28 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 028 NowSeason                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SubSeasonDetailContentViewModel : DataModel
    {
        public List<ConditionDetail>?                   ConditionDetailList                     { get; set; }
        public List<ISubSeasonConditionStatus>?         ConditionList                           { get; set; }
        public List<int>?                               SelectedSubSeasonIdList                 { get; set; }
        public int                                      NowSeason                               { get; set; }

        public static SubSeasonDetailContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonDetailContentViewModel() { Pointer= p0 };

            value.ConditionDetailList                       = GetObjectList<ConditionDetail>(new IntPtr(p + 0x010), ReversePrism.DataModels.ConditionDetail.FromPointer); // 024664D945E8 0x10 ConditionDetailList         ( 000185D2C6A8 ModelClassListType List`1<ConditionDetail> List`1<ConditionDetail> List<ConditionDetail> Pointer )
            value.ConditionList                             = GetObjectList<ISubSeasonConditionStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISubSeasonConditionStatus.FromPointer); // 024664D94608 0x18 ConditionList               ( 000185D0CF78 ModelClassListType IReadOnlyList`1<ISubSeasonConditionStatus> IReadOnlyList`1<ISubSeasonConditionStatus> List<ISubSeasonConditionStatus> Pointer )
            value.SelectedSubSeasonIdList                   = GetInt32List(new IntPtr(p + 0x020)); // 024664D94628 0x20 SelectedSubSeasonIdList     ( 000185D11E28 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.NowSeason                                 = GetInt32(new IntPtr(p + 0x028)); // 024664D94648 0x28 NowSeason                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
