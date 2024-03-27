using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AwakenButtonTextId                       int IL2CPP_TYPE_I4
    // 000 TrainingButtonTextId                     int IL2CPP_TYPE_I4
    // 000 SkillLvUpButtonTextId                    int IL2CPP_TYPE_I4
    // 020 CanAwakenButton                          000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 CanTrainingButton                        000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 CanSkillLvUpButton                       000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 038 AwakenButtonText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TrainingButtonText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SkillLvUpButtonText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 onButtonChenged                          Subject`1<ValueTuple`3<bool, bool, bool>> IL2CPP_TYPE_GENERICINST
    public partial class PIdolUpgradingButtonView
    {
        public ToggleButton?                            CanAwakenButton                         { get; set; }
        public ToggleButton?                            CanTrainingButton                       { get; set; }
        public ToggleButton?                            CanSkillLvUpButton                      { get; set; }
        public UITextMeshProUGUI?                       AwakenButtonText                        { get; set; }
        public UITextMeshProUGUI?                       TrainingButtonText                      { get; set; }
        public UITextMeshProUGUI?                       SkillLvUpButtonText                     { get; set; }

        public static PIdolUpgradingButtonView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolUpgradingButtonView();

            value.CanAwakenButton                           = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DA39A0C0 0x20 CanAwakenButton             ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.CanTrainingButton                         = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DA39A0E0 0x28 CanTrainingButton           ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.CanSkillLvUpButton                        = GetObject<ToggleButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DA39A100 0x30 CanSkillLvUpButton          ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.AwakenButtonText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA39A120 0x38 AwakenButtonText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TrainingButtonText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA39A140 0x40 TrainingButtonText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SkillLvUpButtonText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA39A160 0x48 SkillLvUpButtonText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
