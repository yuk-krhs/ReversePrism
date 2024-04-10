using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DefaultBackground                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 SpecialBackground                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 OpenUnitListButton                       000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 UnitNameInputField                       0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 040 SwitchDisplayTab                         0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 048 DisplayParents                           000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 050 UseRecommendedButton                     000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 UnitEditCarousel                         00018658DD80 ModelClassType LiveUnitEditCarousel LiveUnitEditCarousel LiveUnitEditCarousel Pointer
    // 060 SwitchStatusInfoDisplayButton            0001865B3940 ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer
    // 068 TotalParameterText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 DressIcons                               000185B91B90 ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer
    // 078 HairstyleIcons                           000185B91B90 ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer
    // 080 onClickUseRecommended                    Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 088 onClickOpenUnitList                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class LiveUnitEditView : DataModel
    {
        public GameObject?                              DefaultBackground                       { get; set; }
        public GameObject?                              SpecialBackground                       { get; set; }
        public ButtonBase?                              OpenUnitListButton                      { get; set; }
        public CommonInputFieldTMP?                     UnitNameInputField                      { get; set; }
        public UITabGroupEx?                            SwitchDisplayTab                        { get; set; }
        public List<GameObject>?                        DisplayParents                          { get; set; }
        public ButtonBase?                              UseRecommendedButton                    { get; set; }
        public LiveUnitEditCarousel?                    UnitEditCarousel                        { get; set; }
        public ClickNumberCountedButton?                SwitchStatusInfoDisplayButton           { get; set; }
        public UITextMeshProUGUI?                       TotalParameterText                      { get; set; }
        public List<LiveUnitEditCostumeIcon>?           DressIcons                              { get; set; }
        public List<LiveUnitEditCostumeIcon>?           HairstyleIcons                          { get; set; }

        public static LiveUnitEditView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditView() { Pointer= p0 };

            value.DefaultBackground                         = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 02466A2E3740 0x20 DefaultBackground           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SpecialBackground                         = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466A2E3760 0x28 SpecialBackground           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OpenUnitListButton                        = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466A2E3780 0x30 OpenUnitListButton          ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.UnitNameInputField                        = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x038), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 02466A2E37A0 0x38 UnitNameInputField          ( 0001865E5200 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.SwitchDisplayTab                          = GetObject<UITabGroupEx>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 02466A2E37C0 0x40 SwitchDisplayTab            ( 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.DisplayParents                            = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466A2E37E0 0x48 DisplayParents              ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.UseRecommendedButton                      = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466A2E3800 0x50 UseRecommendedButton        ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.UnitEditCarousel                          = GetObject<LiveUnitEditCarousel>(new IntPtr(p + 0x058), ReversePrism.DataModels.LiveUnitEditCarousel.FromPointer); // 02466A2E3820 0x58 UnitEditCarousel            ( 00018658DD80 ModelClassType LiveUnitEditCarousel LiveUnitEditCarousel LiveUnitEditCarousel Pointer )
            value.SwitchStatusInfoDisplayButton             = GetObject<ClickNumberCountedButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.ClickNumberCountedButton.FromPointer); // 02466A2E3840 0x60 SwitchStatusInfoDisplayButton ( 0001865B3940 ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer )
            value.TotalParameterText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2E3860 0x68 TotalParameterText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DressIcons                                = GetObjectList<LiveUnitEditCostumeIcon>(new IntPtr(p + 0x070), ReversePrism.DataModels.LiveUnitEditCostumeIcon.FromPointer); // 02466A2E3880 0x70 DressIcons                  ( 000185B91B90 ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer )
            value.HairstyleIcons                            = GetObjectList<LiveUnitEditCostumeIcon>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveUnitEditCostumeIcon.FromPointer); // 02466A2E38A0 0x78 HairstyleIcons              ( 000185B91B90 ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer )

            return value;
        }
    }
}
