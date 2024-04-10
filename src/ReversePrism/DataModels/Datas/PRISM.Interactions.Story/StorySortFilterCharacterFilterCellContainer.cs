using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharacterFilterCellPos                   0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 UnitIconImage                            0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 CharacterFilterCellPrefab                00018659D690 ModelClassType StorySortFilterCharacterFilterCell StorySortFilterCharacterFilterCell StorySortFilterCharacterFilterCell Pointer
    // 038 onClickCellSubject                       Subject`1<StorySortFilterCharacterFilterCellData> IL2CPP_TYPE_GENERICINST
    public partial class StorySortFilterCharacterFilterCellContainer : DataModel
    {
        public Transform?                               CharacterFilterCellPos                  { get; set; }
        public UIImage?                                 UnitIconImage                           { get; set; }
        public StorySortFilterCharacterFilterCell?      CharacterFilterCellPrefab               { get; set; }

        public static StorySortFilterCharacterFilterCellContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterCharacterFilterCellContainer() { Pointer= p0 };

            value.CharacterFilterCellPos                    = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 02466B9D2918 0x20 CharacterFilterCellPos      ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.UnitIconImage                             = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 02466B9D2938 0x28 UnitIconImage               ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.CharacterFilterCellPrefab                 = GetObject<StorySortFilterCharacterFilterCell>(new IntPtr(p + 0x030), ReversePrism.DataModels.StorySortFilterCharacterFilterCell.FromPointer); // 02466B9D2958 0x30 CharacterFilterCellPrefab   ( 00018659D690 ModelClassType StorySortFilterCharacterFilterCell StorySortFilterCharacterFilterCell StorySortFilterCharacterFilterCell Pointer )

            return value;
        }
    }
}
