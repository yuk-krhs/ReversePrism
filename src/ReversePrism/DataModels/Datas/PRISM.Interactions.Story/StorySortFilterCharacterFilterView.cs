using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContainerPos                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 ContainerPrefab                          00018659DDF0 ModelClassType StorySortFilterCharacterFilterCellContainer StorySortFilterCharacterFilterCellContainer StorySortFilterCharacterFilterCellContainer Pointer
    // 030 CharacterResetButton                     0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 onClickIcon                              Subject`1<StorySortFilterCharacterFilterCellData> IL2CPP_TYPE_GENERICINST
    // 040 ViewModel                                00018659F0E0 ModelClassType StorySortFilterCharacterFilterViewModel StorySortFilterCharacterFilterViewModel StorySortFilterCharacterFilterViewModel Pointer
    public partial class StorySortFilterCharacterFilterView
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
            var value   = new StorySortFilterCharacterFilterView();

            value.ContainerPos                              = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0270DB94D598 0x20 ContainerPos                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ContainerPrefab                           = GetObject<StorySortFilterCharacterFilterCellContainer>(new IntPtr(p + 0x028), ReversePrism.DataModels.StorySortFilterCharacterFilterCellContainer.FromPointer); // 0270DB94D5B8 0x28 ContainerPrefab             ( 00018659DDF0 ModelClassType StorySortFilterCharacterFilterCellContainer StorySortFilterCharacterFilterCellContainer StorySortFilterCharacterFilterCellContainer Pointer )
            value.CharacterResetButton                      = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB94D5D8 0x30 CharacterResetButton        ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<StorySortFilterCharacterFilterViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.StorySortFilterCharacterFilterViewModel.FromPointer); // 0270DB94D618 0x40 ViewModel                   ( 00018659F0E0 ModelClassType StorySortFilterCharacterFilterViewModel StorySortFilterCharacterFilterViewModel StorySortFilterCharacterFilterViewModel Pointer )

            return value;
        }
    }
}
