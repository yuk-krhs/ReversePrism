using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelectedFilterTypes                      ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 SortFilterSettings                       ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    public partial class ProfileAchievementSortFilterSaveData : DataModel
    {
        public List<int>?                               SelectedFilterTypes                     { get; set; }
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }

        public static ProfileAchievementSortFilterSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileAchievementSortFilterSaveData() { Pointer= p0 };

            value.SelectedFilterTypes                       = GetInt32List(new IntPtr(p + 0x010)); // 0x10 SelectedFilterTypes         ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x018), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 0x18 SortFilterSettings          ( ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )

            return value;
        }
    }
}
