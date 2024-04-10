using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 028 ViewModel                                0001865447A0 ModelClassType SpecialMissionHintPopupViewModel SpecialMissionHintPopupViewModel SpecialMissionHintPopupViewModel Pointer
    // 030 MissionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 HintText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SpecialMissionHintPopupView : DataModel
    {
        public SpecialMissionHintPopupViewModel?        ViewModel                               { get; set; }
        public UITextMeshProUGUI?                       MissionText                             { get; set; }
        public UITextMeshProUGUI?                       HintText                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static SpecialMissionHintPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionHintPopupView() { Pointer= p0 };

            value.ViewModel                                 = GetObject<SpecialMissionHintPopupViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpecialMissionHintPopupViewModel.FromPointer); // 02466BDDD8C8 0x28 ViewModel                   ( 0001865447A0 ModelClassType SpecialMissionHintPopupViewModel SpecialMissionHintPopupViewModel SpecialMissionHintPopupViewModel Pointer )
            value.MissionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDDD8E8 0x30 MissionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.HintText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BDDD908 0x38 HintText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466BDDD928 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
