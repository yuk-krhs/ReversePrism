using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CellData                                 ModelClassType IStoryLastCategoryCellData IStoryLastCategoryCellData IStoryLastCategoryCellData Pointer
    // 018 Story                                    ModelClassType IStoryStatus IStoryStatus IStoryStatus Pointer
    // 020 EntryCharacterIdList                     ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 028 AdvScenarioInfo                          ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer
    // 030 ReleaseDate                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class SortFilteredStoryCellData : DataModel
    {
        public IStoryLastCategoryCellData?              CellData                                { get; set; }
        public IStoryStatus?                            Story                                   { get; set; }
        public List<int>?                               EntryCharacterIdList                    { get; set; }
        public IAdvScenarioInfo?                        AdvScenarioInfo                         { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }

        public static SortFilteredStoryCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortFilteredStoryCellData() { Pointer= p0 };

            value.CellData                                  = GetObject<IStoryLastCategoryCellData>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoryLastCategoryCellData.FromPointer); // 0x10 CellData                    ( ModelClassType IStoryLastCategoryCellData IStoryLastCategoryCellData IStoryLastCategoryCellData Pointer )
            value.Story                                     = GetObject<IStoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStoryStatus.FromPointer); // 0x18 Story                       ( ModelClassType IStoryStatus IStoryStatus IStoryStatus Pointer )
            value.EntryCharacterIdList                      = GetInt32List(new IntPtr(p + 0x020)); // 0x20 EntryCharacterIdList        ( ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.AdvScenarioInfo                           = GetObject<IAdvScenarioInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.IAdvScenarioInfo.FromPointer); // 0x28 AdvScenarioInfo             ( ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x030)); // 0x30 ReleaseDate                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
