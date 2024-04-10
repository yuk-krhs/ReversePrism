using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TryOnModeToggle                          0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 028 ShowUnlockedCostumeOnlyToggle            000186682710 ModelClassType Toggle Toggle Toggle Pointer
    // 030 CostumeTabGroup                          0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 038 CostumeCategoryText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 CostumeName                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 OkButton                                 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 OpenPresetButton                         000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 058 Background                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 TryOnModeBackground                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 OkButtonGrayOut                          0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 070 PresetButtonGrayOut                      0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 078 costumeTabSubject                        Subject`1<CostumeCategory> IL2CPP_TYPE_GENERICINST
    public partial class LiveCostumeChangeMainView : DataModel
    {
        public ToggleSwitch?                            TryOnModeToggle                         { get; set; }
        public Toggle?                                  ShowUnlockedCostumeOnlyToggle           { get; set; }
        public UITabGroupEx?                            CostumeTabGroup                         { get; set; }
        public UITextMeshProUGUI?                       CostumeCategoryText                     { get; set; }
        public UITextMeshProUGUI?                       CostumeName                             { get; set; }
        public ButtonBase?                              OkButton                                { get; set; }
        public ButtonBase?                              OpenPresetButton                        { get; set; }
        public GameObject?                              Background                              { get; set; }
        public GameObject?                              TryOnModeBackground                     { get; set; }
        public UIGrayOutController?                     OkButtonGrayOut                         { get; set; }
        public UIGrayOutController?                     PresetButtonGrayOut                     { get; set; }

        public static LiveCostumeChangeMainView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveCostumeChangeMainView() { Pointer= p0 };

            value.TryOnModeToggle                           = GetObject<ToggleSwitch>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 02466B43CB10 0x20 TryOnModeToggle             ( 0001866876D0 ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.ShowUnlockedCostumeOnlyToggle             = GetObject<Toggle>(new IntPtr(p + 0x028), ReversePrism.DataModels.Toggle.FromPointer); // 02466B43CB30 0x28 ShowUnlockedCostumeOnlyToggle ( 000186682710 ModelClassType Toggle Toggle Toggle Pointer )
            value.CostumeTabGroup                           = GetObject<UITabGroupEx>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 02466B43CB50 0x30 CostumeTabGroup             ( 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.CostumeCategoryText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B43CB70 0x38 CostumeCategoryText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CostumeName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B43CB90 0x40 CostumeName                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OkButton                                  = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466B43CBB0 0x48 OkButton                    ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.OpenPresetButton                          = GetObject<ButtonBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466B43CBD0 0x50 OpenPresetButton            ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.Background                                = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466B43CBF0 0x58 Background                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TryOnModeBackground                       = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466B43CC10 0x60 TryOnModeBackground         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OkButtonGrayOut                           = GetObject<UIGrayOutController>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 02466B43CC30 0x68 OkButtonGrayOut             ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.PresetButtonGrayOut                       = GetObject<UIGrayOutController>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 02466B43CC50 0x70 PresetButtonGrayOut         ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )

            return value;
        }
    }
}
