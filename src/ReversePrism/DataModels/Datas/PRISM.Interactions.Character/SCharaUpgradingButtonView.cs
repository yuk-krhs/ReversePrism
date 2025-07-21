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
    // 020 CanMasterTrainingButton                  ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 028 CanTrainingButton                        ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 MasterTrainingButtonText                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TrainingButtonText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 onButtonChange                           Subject`1<ValueTuple`2<bool, bool>> IL2CPP_TYPE_GENERICINST
    public partial class SCharaUpgradingButtonView : DataModel
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
            var value   = new SCharaUpgradingButtonView() { Pointer= p0 };

            value.CanMasterTrainingButton                   = GetObject<ToggleButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x20 CanMasterTrainingButton     ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.CanTrainingButton                         = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x28 CanTrainingButton           ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.MasterTrainingButtonText                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 MasterTrainingButtonText    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TrainingButtonText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TrainingButtonText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
