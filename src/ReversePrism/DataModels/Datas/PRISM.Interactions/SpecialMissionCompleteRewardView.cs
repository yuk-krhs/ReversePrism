using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardIcons                              000185CA1078 ModelClassListType RewardItemIcon[] RewardItemIcon[] List<RewardItemIcon> Pointer
    // 028 MissionProgresLabelText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 MissionProgresText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 MissionCompleteObject                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 MissionTermRoot                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 MissionTermLabelText                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 MissionTermText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 MissionCompleteLabelText                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 CompleteRewardReceivedObject             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class SpecialMissionCompleteRewardView : DataModel
    {
        public List<RewardItemIcon>?                    RewardIcons                             { get; set; }
        public UITextMeshProUGUI?                       MissionProgresLabelText                 { get; set; }
        public UITextMeshProUGUI?                       MissionProgresText                      { get; set; }
        public GameObject?                              MissionCompleteObject                   { get; set; }
        public GameObject?                              MissionTermRoot                         { get; set; }
        public UITextMeshProUGUI?                       MissionTermLabelText                    { get; set; }
        public UITextMeshProUGUI?                       MissionTermText                         { get; set; }
        public UITextMeshProUGUI?                       MissionCompleteLabelText                { get; set; }
        public GameObject?                              CompleteRewardReceivedObject            { get; set; }

        public static SpecialMissionCompleteRewardView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionCompleteRewardView() { Pointer= p0 };

            value.RewardIcons                               = GetObjectList<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 02466BDDD698 0x20 RewardIcons                 ( 000185CA1078 ModelClassListType RewardItemIcon[] RewardItemIcon[] List<RewardItemIcon> Pointer )
            value.MissionProgresLabelText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDDD6B8 0x28 MissionProgresLabelText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MissionProgresText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDDD6D8 0x30 MissionProgresText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MissionCompleteObject                     = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDDD6F8 0x38 MissionCompleteObject       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionTermRoot                           = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDDD718 0x40 MissionTermRoot             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.MissionTermLabelText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDDD738 0x48 MissionTermLabelText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MissionTermText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDDD758 0x50 MissionTermText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MissionCompleteLabelText                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDDD778 0x58 MissionCompleteLabelText    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CompleteRewardReceivedObject              = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466BDDD798 0x60 CompleteRewardReceivedObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
