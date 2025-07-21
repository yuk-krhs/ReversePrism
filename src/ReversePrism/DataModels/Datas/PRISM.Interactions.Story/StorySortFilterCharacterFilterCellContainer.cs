using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharacterFilterCellPos                   ModelClassType Transform Transform Transform Pointer
    // 028 UnitIconImage                            ModelClassType UIImage UIImage UIImage Pointer
    // 030 CharacterFilterCellPrefab                ModelClassType StorySortFilterCharacterFilterCell StorySortFilterCharacterFilterCell StorySortFilterCharacterFilterCell Pointer
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

            value.CharacterFilterCellPos                    = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 CharacterFilterCellPos      ( ModelClassType Transform Transform Transform Pointer )
            value.UnitIconImage                             = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 UnitIconImage               ( ModelClassType UIImage UIImage UIImage Pointer )
            value.CharacterFilterCellPrefab                 = GetObject<StorySortFilterCharacterFilterCell>(new IntPtr(p + 0x030), ReversePrism.DataModels.StorySortFilterCharacterFilterCell.FromPointer); // 0x30 CharacterFilterCellPrefab   ( ModelClassType StorySortFilterCharacterFilterCell StorySortFilterCharacterFilterCell StorySortFilterCharacterFilterCell Pointer )

            return value;
        }
    }
}
