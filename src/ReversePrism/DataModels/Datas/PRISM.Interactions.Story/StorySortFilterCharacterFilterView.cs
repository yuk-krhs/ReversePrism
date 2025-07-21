using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContainerPos                             ModelClassType Transform Transform Transform Pointer
    // 028 ContainerPrefab                          ModelClassType StorySortFilterCharacterFilterCellContainer StorySortFilterCharacterFilterCellContainer StorySortFilterCharacterFilterCellContainer Pointer
    // 030 CharacterResetButton                     ModelClassType UIButton UIButton UIButton Pointer
    // 038 onClickIcon                              Subject`1<StorySortFilterCharacterFilterCellData> IL2CPP_TYPE_GENERICINST
    // 040 ViewModel                                ModelClassType StorySortFilterCharacterFilterViewModel StorySortFilterCharacterFilterViewModel StorySortFilterCharacterFilterViewModel Pointer
    public partial class StorySortFilterCharacterFilterView : DataModel
    {
        public Transform?                               ContainerPos                            { get; set; }
        public StorySortFilterCharacterFilterCellContainer? ContainerPrefab                         { get; set; }
        public UIButton?                                CharacterResetButton                    { get; set; }
        public StorySortFilterCharacterFilterViewModel? ViewModel                               { get; set; }

        public static StorySortFilterCharacterFilterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterCharacterFilterView() { Pointer= p0 };

            value.ContainerPos                              = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 ContainerPos                ( ModelClassType Transform Transform Transform Pointer )
            value.ContainerPrefab                           = GetObject<StorySortFilterCharacterFilterCellContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.StorySortFilterCharacterFilterCellContainer.FromPointer); // 0x28 ContainerPrefab             ( ModelClassType StorySortFilterCharacterFilterCellContainer StorySortFilterCharacterFilterCellContainer StorySortFilterCharacterFilterCellContainer Pointer )
            value.CharacterResetButton                      = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 CharacterResetButton        ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<StorySortFilterCharacterFilterViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.StorySortFilterCharacterFilterViewModel.FromPointer); // 0x40 ViewModel                   ( ModelClassType StorySortFilterCharacterFilterViewModel StorySortFilterCharacterFilterViewModel StorySortFilterCharacterFilterViewModel Pointer )

            return value;
        }
    }
}
