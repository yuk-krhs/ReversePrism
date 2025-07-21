using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AchievedFilters                          ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 CategoryFilters                          ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 RewardFilters                            ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 SortFilterSettings                       ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class MissionFilterSaveData : DataModel
    {
        public List<int>?                               AchievedFilters                         { get; set; }
        public List<int>?                               CategoryFilters                         { get; set; }
        public List<int>?                               RewardFilters                           { get; set; }
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }

        public static MissionFilterSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionFilterSaveData() { Pointer= p0 };

            value.AchievedFilters                           = GetInt32List(new IntPtr(p + 0x010)); // 0x10 AchievedFilters             ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.CategoryFilters                           = GetInt32List(new IntPtr(p + 0x018)); // 0x18 CategoryFilters             ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.RewardFilters                             = GetInt32List(new IntPtr(p + 0x020)); // 0x20 RewardFilters               ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 0x28 SortFilterSettings          ( ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
