using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DefaultBackground                        ModelClassType GameObject GameObject GameObject Pointer
    // 028 SpecialBackground                        ModelClassType GameObject GameObject GameObject Pointer
    // 030 OpenUnitListButton                       ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 038 UnitNameInputField                       ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 040 ResetButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 048 SwitchDisplayTab                         ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 050 DisplayParents                           ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 UseRecommendedButton                     ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 060 UnitEditCarousel                         ModelClassType LiveUnitEditCarousel LiveUnitEditCarousel LiveUnitEditCarousel Pointer
    // 068 SwitchStatusInfoDisplayButton            ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer
    // 070 TotalParameterText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 DressIcons                               ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer
    // 080 HairstyleIcons                           ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer
    // 088 onClickUseRecommended                    Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 onClickOpenUnitList                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class LiveUnitEditView : DataModel
    {
        public GameObject?                              DefaultBackground                       { get; set; }
        public GameObject?                              SpecialBackground                       { get; set; }
        public ButtonBase?                              OpenUnitListButton                      { get; set; }
        public CommonInputFieldTMP?                     UnitNameInputField                      { get; set; }
        public ButtonBase?                              ResetButton                             { get; set; }
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

            value.DefaultBackground                         = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 DefaultBackground           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SpecialBackground                         = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 SpecialBackground           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.OpenUnitListButton                        = GetObject<ButtonBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x30 OpenUnitListButton          ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.UnitNameInputField                        = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x038), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0x38 UnitNameInputField          ( ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.ResetButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x40 ResetButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.SwitchDisplayTab                          = GetObject<UITabGroupEx>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x48 SwitchDisplayTab            ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.DisplayParents                            = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 DisplayParents              ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.UseRecommendedButton                      = GetObject<ButtonBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x58 UseRecommendedButton        ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.UnitEditCarousel                          = GetObject<LiveUnitEditCarousel>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveUnitEditCarousel.FromPointer); // 0x60 UnitEditCarousel            ( ModelClassType LiveUnitEditCarousel LiveUnitEditCarousel LiveUnitEditCarousel Pointer )
            value.SwitchStatusInfoDisplayButton             = GetObject<ClickNumberCountedButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.ClickNumberCountedButton.FromPointer); // 0x68 SwitchStatusInfoDisplayButton ( ModelClassType ClickNumberCountedButton ClickNumberCountedButton ClickNumberCountedButton Pointer )
            value.TotalParameterText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 TotalParameterText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DressIcons                                = GetObjectList<LiveUnitEditCostumeIcon>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveUnitEditCostumeIcon.FromPointer); // 0x78 DressIcons                  ( ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer )
            value.HairstyleIcons                            = GetObjectList<LiveUnitEditCostumeIcon>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveUnitEditCostumeIcon.FromPointer); // 0x80 HairstyleIcons              ( ModelClassListType LiveUnitEditCostumeIcon[] LiveUnitEditCostumeIcon[] List<LiveUnitEditCostumeIcon> Pointer )

            return value;
        }
    }
}
