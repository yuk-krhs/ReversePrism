using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MasterTrainingButtonTextId               int IL2CPP_TYPE_I4
    // 000 TrainingButtonTextId                     int IL2CPP_TYPE_I4
    // 020 CanMasterTrainingButton                  000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 CanTrainingButton                        000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 MasterTrainingButtonText                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TrainingButtonText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 onButtonChange                           Subject`1<ValueTuple`2<bool, bool>> IL2CPP_TYPE_GENERICINST
    public partial class SCharaUpgradingButtonView
    {
        public ToggleButton?                            CanMasterTrainingButton                 { get; set; }
        public ToggleButton?                            CanTrainingButton                       { get; set; }
        public UITextMeshProUGUI?                       MasterTrainingButtonText                { get; set; }
        public UITextMeshProUGUI?                       TrainingButtonText                      { get; set; }

        public static SCharaUpgradingButtonView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaUpgradingButtonView();

            value.CanMasterTrainingButton                   = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DA39BCC0 0x20 CanMasterTrainingButton     ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.CanTrainingButton                         = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DA39BCE0 0x28 CanTrainingButton           ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.MasterTrainingButtonText                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA39BD00 0x30 MasterTrainingButtonText    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TrainingButtonText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA39BD20 0x38 TrainingButtonText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
