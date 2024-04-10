using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UNIT_NAME_MAX_LENGTH                     int IL2CPP_TYPE_I4
    // 020 DefaultBackground                        0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 028 SpecialBackground                        0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer
    // 030 OpenUnitListButton                       0001865158C0 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 UnitNameInputField                       0001865E53E0 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 040 SwitchContentTabGroup                    0001866F5E40 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 048 TabContentParents                        000185B81600 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 050 UseRecommendedButton                     0001865158C0 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 DressIcons                               000185B91C90 ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer
    // 060 HairstyleIcons                           000185B91C90 ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer
    public partial class LiveUnitConfirmationUnitEditViewBase : DataModel
    {
        public GameObject?                              DefaultBackground                       { get; set; }
        public GameObject?                              SpecialBackground                       { get; set; }
        public ButtonBase?                              OpenUnitListButton                      { get; set; }
        public CommonInputFieldTMP?                     UnitNameInputField                      { get; set; }
        public UITabGroupEx?                            SwitchContentTabGroup                   { get; set; }
        public List<GameObject>?                        TabContentParents                       { get; set; }
        public ButtonBase?                              UseRecommendedButton                    { get; set; }
        public List<LiveUnitEditCostumeIcon>?           DressIcons                              { get; set; }
        public List<LiveUnitEditCostumeIcon>?           HairstyleIcons                          { get; set; }

        public static LiveUnitConfirmationUnitEditViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationUnitEditViewBase() { Pointer= p0 };

            value.DefaultBackground                         = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466517E260 0x20 DefaultBackground           ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.SpecialBackground                         = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466517E280 0x28 SpecialBackground           ( 0001865D81D0 ModelClassType GameObject GameObject GameObject Pointer )
            value.OpenUnitListButton                        = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466517E2A0 0x30 OpenUnitListButton          ( 0001865158C0 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.UnitNameInputField                        = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x038), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 02466517E2C0 0x38 UnitNameInputField          ( 0001865E53E0 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.SwitchContentTabGroup                     = GetObject<UITabGroupEx>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 02466517E2E0 0x40 SwitchContentTabGroup       ( 0001866F5E40 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.TabContentParents                         = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466517E300 0x48 TabContentParents           ( 000185B81600 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.UseRecommendedButton                      = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466517E320 0x50 UseRecommendedButton        ( 0001865158C0 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.DressIcons                                = GetObjectList<LiveUnitEditCostumeIcon>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveUnitEditCostumeIcon.FromPointer); // 02466517E340 0x58 DressIcons                  ( 000185B91C90 ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer )
            value.HairstyleIcons                            = GetObjectList<LiveUnitEditCostumeIcon>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveUnitEditCostumeIcon.FromPointer); // 02466517E360 0x60 HairstyleIcons              ( 000185B91C90 ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer )

            return value;
        }
    }
}
