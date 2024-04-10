using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharacterBaseIcon                        000186599240 ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer
    // 028 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 UiGrayOutController                      0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 038 SelectFrame                              0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 040 Data                                     00018659E440 ModelClassType StorySortFilterCharacterFilterCellData StorySortFilterCharacterFilterCellData StorySortFilterCharacterFilterCellData Pointer
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

            value.CharacterBaseIcon                         = GetObject<CharacterBaseIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterBaseIcon.FromPointer); // 02466B9D25C8 0x20 CharacterBaseIcon           ( 000186599240 ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer )
            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 02466B9D25E8 0x28 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UiGrayOutController                       = GetObject<UIGrayOutController>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 02466B9D2608 0x30 UiGrayOutController         ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.SelectFrame                               = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 02466B9D2628 0x38 SelectFrame                 ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.Data                                      = GetObject<StorySortFilterCharacterFilterCellData>(new IntPtr(p + 0x040), ReversePrism.DataModels.StorySortFilterCharacterFilterCellData.FromPointer); // 02466B9D2648 0x40 Data                        ( 00018659E440 ModelClassType StorySortFilterCharacterFilterCellData StorySortFilterCharacterFilterCellData StorySortFilterCharacterFilterCellData Pointer )

            return value;
        }
    }
}
