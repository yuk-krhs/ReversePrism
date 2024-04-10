using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FavoriteFilterRow                        0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 028 IdolFilterRow                            0001866E8700 ModelClassType UIFilterCharacterGroup UIFilterCharacterGroup UIFilterCharacterGroup Pointer
    // 030 LiveSkillFilterRow                       0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 038 BtnRest                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 Vm                                       000186563970 ModelClassType FesIdolSearchPopupViewModel FesIdolSearchPopupViewModel FesIdolSearchPopupViewModel Pointer
    public partial class FesIdolFilterView : DataModel
    {
        public UIFilterGroup?                           FavoriteFilterRow                       { get; set; }
        public UIFilterCharacterGroup?                  IdolFilterRow                           { get; set; }
        public UIFilterGroup?                           LiveSkillFilterRow                      { get; set; }
        public UIButton?                                BtnRest                                 { get; set; }
        public FesIdolSearchPopupViewModel?             Vm                                      { get; set; }

        public static FesIdolFilterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesIdolFilterView() { Pointer= p0 };

            value.FavoriteFilterRow                         = GetObject<UIFilterGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 02466A2FE9B0 0x20 FavoriteFilterRow           ( 0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.IdolFilterRow                             = GetObject<UIFilterCharacterGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIFilterCharacterGroup.FromPointer); // 02466A2FE9D0 0x28 IdolFilterRow               ( 0001866E8700 ModelClassType UIFilterCharacterGroup UIFilterCharacterGroup UIFilterCharacterGroup Pointer )
            value.LiveSkillFilterRow                        = GetObject<UIFilterGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 02466A2FE9F0 0x30 LiveSkillFilterRow          ( 0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.BtnRest                                   = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466A2FEA10 0x38 BtnRest                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Vm                                        = GetObject<FesIdolSearchPopupViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.FesIdolSearchPopupViewModel.FromPointer); // 02466A2FEA30 0x40 Vm                          ( 000186563970 ModelClassType FesIdolSearchPopupViewModel FesIdolSearchPopupViewModel FesIdolSearchPopupViewModel Pointer )

            return value;
        }
    }
}
