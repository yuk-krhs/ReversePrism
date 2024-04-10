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
    // 030 StarFilterRow                            0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 038 AwakeningFilterRow                       0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 040 LiveSkillFilterRow                       0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 048 IdolSkillIconIncludeUnlock               000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 050 IdolSkillIconFilterRow                   0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 058 EventFilterRow                           0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 060 BtnRest                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 Vm                                       00018654B280 ModelClassType ProduceIdolSearchPopupViewModel ProduceIdolSearchPopupViewModel ProduceIdolSearchPopupViewModel Pointer
    public partial class ProduceIdolFilterView : DataModel
    {
        public UIFilterGroup?                           FavoriteFilterRow                       { get; set; }
        public UIFilterCharacterGroup?                  IdolFilterRow                           { get; set; }
        public UIFilterGroup?                           StarFilterRow                           { get; set; }
        public UIFilterGroup?                           AwakeningFilterRow                      { get; set; }
        public UIFilterGroup?                           LiveSkillFilterRow                      { get; set; }
        public ToggleButton?                            IdolSkillIconIncludeUnlock              { get; set; }
        public UIFilterGroup?                           IdolSkillIconFilterRow                  { get; set; }
        public UIFilterGroup?                           EventFilterRow                          { get; set; }
        public UIButton?                                BtnRest                                 { get; set; }
        public ProduceIdolSearchPopupViewModel?         Vm                                      { get; set; }

        public static ProduceIdolFilterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolFilterView() { Pointer= p0 };

            value.FavoriteFilterRow                         = GetObject<UIFilterGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 02466A3835F0 0x20 FavoriteFilterRow           ( 0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.IdolFilterRow                             = GetObject<UIFilterCharacterGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIFilterCharacterGroup.FromPointer); // 02466A383610 0x28 IdolFilterRow               ( 0001866E8700 ModelClassType UIFilterCharacterGroup UIFilterCharacterGroup UIFilterCharacterGroup Pointer )
            value.StarFilterRow                             = GetObject<UIFilterGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 02466A383630 0x30 StarFilterRow               ( 0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.AwakeningFilterRow                        = GetObject<UIFilterGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 02466A383650 0x38 AwakeningFilterRow          ( 0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.LiveSkillFilterRow                        = GetObject<UIFilterGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 02466A383670 0x40 LiveSkillFilterRow          ( 0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.IdolSkillIconIncludeUnlock                = GetObject<ToggleButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButton.FromPointer); // 02466A383690 0x48 IdolSkillIconIncludeUnlock  ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.IdolSkillIconFilterRow                    = GetObject<UIFilterGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 02466A3836B0 0x50 IdolSkillIconFilterRow      ( 0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.EventFilterRow                            = GetObject<UIFilterGroup>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 02466A3836D0 0x58 EventFilterRow              ( 0001866E8E30 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.BtnRest                                   = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3836F0 0x60 BtnRest                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Vm                                        = GetObject<ProduceIdolSearchPopupViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.ProduceIdolSearchPopupViewModel.FromPointer); // 02466A383710 0x68 Vm                          ( 00018654B280 ModelClassType ProduceIdolSearchPopupViewModel ProduceIdolSearchPopupViewModel ProduceIdolSearchPopupViewModel Pointer )

            return value;
        }
    }
}
