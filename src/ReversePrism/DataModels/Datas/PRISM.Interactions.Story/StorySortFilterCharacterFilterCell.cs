using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharacterBaseIcon                        ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer
    // 028 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 030 UiGrayOutController                      ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 038 SelectFrame                              ModelClassType UIImage UIImage UIImage Pointer
    // 040 Data                                     ModelClassType StorySortFilterCharacterFilterCellData StorySortFilterCharacterFilterCellData StorySortFilterCharacterFilterCellData Pointer
    public partial class StorySortFilterCharacterFilterCell : DataModel
    {
        public CharacterBaseIcon?                       CharacterBaseIcon                       { get; set; }
        public UIButton?                                Button                                  { get; set; }
        public UIGrayOutController?                     UiGrayOutController                     { get; set; }
        public UIImage?                                 SelectFrame                             { get; set; }
        public StorySortFilterCharacterFilterCellData?  Data                                    { get; set; }

        public static StorySortFilterCharacterFilterCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorySortFilterCharacterFilterCell() { Pointer= p0 };

            value.CharacterBaseIcon                         = GetObject<CharacterBaseIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterBaseIcon.FromPointer); // 0x20 CharacterBaseIcon           ( ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer )
            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UiGrayOutController                       = GetObject<UIGrayOutController>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x30 UiGrayOutController         ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.SelectFrame                               = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0x38 SelectFrame                 ( ModelClassType UIImage UIImage UIImage Pointer )
            value.Data                                      = GetObject<StorySortFilterCharacterFilterCellData>(new IntPtr(p + 0x040), ReversePrism.DataModels.StorySortFilterCharacterFilterCellData.FromPointer); // 0x40 Data                        ( ModelClassType StorySortFilterCharacterFilterCellData StorySortFilterCharacterFilterCellData StorySortFilterCharacterFilterCellData Pointer )

            return value;
        }
    }
}
