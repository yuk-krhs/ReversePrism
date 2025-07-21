using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FavoriteFilterRow                        ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 028 IdolFilterRow                            ModelClassType UIFilterCharacterGroup UIFilterCharacterGroup UIFilterCharacterGroup Pointer
    // 030 StarFilterRow                            ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 038 AwakeningFilterRow                       ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 040 LiveSkillFilterRow                       ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 048 IdolSkillIconIncludeUnlock               ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 050 IdolSkillIconFilterRow                   ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 058 EventFilterRow                           ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 060 ProduceIdolTypeFilterRow                 ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 068 BtnRest                                  ModelClassType UIButton UIButton UIButton Pointer
    // 070 Vm                                       ModelClassType ProduceIdolSearchPopupViewModel ProduceIdolSearchPopupViewModel ProduceIdolSearchPopupViewModel Pointer
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
        public UIFilterGroup?                           ProduceIdolTypeFilterRow                { get; set; }
        public UIButton?                                BtnRest                                 { get; set; }
        public ProduceIdolSearchPopupViewModel?         Vm                                      { get; set; }

        public static ProduceIdolFilterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolFilterView() { Pointer= p0 };

            value.FavoriteFilterRow                         = GetObject<UIFilterGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 0x20 FavoriteFilterRow           ( ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.IdolFilterRow                             = GetObject<UIFilterCharacterGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIFilterCharacterGroup.FromPointer); // 0x28 IdolFilterRow               ( ModelClassType UIFilterCharacterGroup UIFilterCharacterGroup UIFilterCharacterGroup Pointer )
            value.StarFilterRow                             = GetObject<UIFilterGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 0x30 StarFilterRow               ( ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.AwakeningFilterRow                        = GetObject<UIFilterGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 0x38 AwakeningFilterRow          ( ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.LiveSkillFilterRow                        = GetObject<UIFilterGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 0x40 LiveSkillFilterRow          ( ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.IdolSkillIconIncludeUnlock                = GetObject<ToggleButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x48 IdolSkillIconIncludeUnlock  ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.IdolSkillIconFilterRow                    = GetObject<UIFilterGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 0x50 IdolSkillIconFilterRow      ( ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.EventFilterRow                            = GetObject<UIFilterGroup>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 0x58 EventFilterRow              ( ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.ProduceIdolTypeFilterRow                  = GetObject<UIFilterGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 0x60 ProduceIdolTypeFilterRow    ( ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.BtnRest                                   = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 BtnRest                     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Vm                                        = GetObject<ProduceIdolSearchPopupViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.ProduceIdolSearchPopupViewModel.FromPointer); // 0x70 Vm                          ( ModelClassType ProduceIdolSearchPopupViewModel ProduceIdolSearchPopupViewModel ProduceIdolSearchPopupViewModel Pointer )

            return value;
        }
    }
}
