using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SortTargetIndex                          ModelPrimitiveType int int int Int32
    // 014 UseFavoriteSortToggle                    ModelPrimitiveType bool bool bool Bool
    // 018 <ReadFilterSelectedIndices>k__BackingField HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 020 <StoryTypeFilterSelectedIndices>k__BackingField HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 028 <SelectedCharacterIds>k__BackingField    HashSet`1<int> IL2CPP_TYPE_GENERICINST
    public partial class StorySortFilterPopupSequencerParameter : DataModel
    {
        public int                                      SortTargetIndex                         { get; set; }
        public bool                                     UseFavoriteSortToggle                   { get; set; }

        public static StorySortFilterPopupSequencerParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterPopupSequencerParameter() { Pointer= p0 };

            value.SortTargetIndex                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 SortTargetIndex             ( ModelPrimitiveType int int int Int32 )
            value.UseFavoriteSortToggle                     = GetBool(new IntPtr(p + 0x014)); // 0x14 UseFavoriteSortToggle       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
