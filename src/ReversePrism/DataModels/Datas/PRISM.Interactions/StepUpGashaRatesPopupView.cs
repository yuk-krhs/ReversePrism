using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiTabGroup                               ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 RateView                                 ModelClassType StepUpGashaRateView StepUpGashaRateView StepUpGashaRateView Pointer
    // 030 IconTapInfoText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 VmList                                   ModelClassListType List`1<StepUpGashaRatesPopupViewModel> List`1<StepUpGashaRatesPopupViewModel> List<StepUpGashaRatesPopupViewModel> Pointer
    // 040 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class StepUpGashaRatesPopupView : DataModel
    {
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public StepUpGashaRateView?                     RateView                                { get; set; }
        public UITextMeshProUGUI?                       IconTapInfoText                         { get; set; }
        public List<StepUpGashaRatesPopupViewModel>?    VmList                                  { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static StepUpGashaRatesPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesPopupView() { Pointer= p0 };

            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 0x20 UiTabGroup                  ( ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.RateView                                  = GetObject<StepUpGashaRateView>(new IntPtr(p + 0x028), ReversePrism.DataModels.StepUpGashaRateView.FromPointer); // 0x28 RateView                    ( ModelClassType StepUpGashaRateView StepUpGashaRateView StepUpGashaRateView Pointer )
            value.IconTapInfoText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 IconTapInfoText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VmList                                    = GetObjectList<StepUpGashaRatesPopupViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.StepUpGashaRatesPopupViewModel.FromPointer); // 0x38 VmList                      ( ModelClassListType List`1<StepUpGashaRatesPopupViewModel> List`1<StepUpGashaRatesPopupViewModel> List<StepUpGashaRatesPopupViewModel> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x48 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
