using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UiTabGroup                               0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer
    // 028 RateView                                 000186589120 ModelClassType StepUpGashaRateView StepUpGashaRateView StepUpGashaRateView Pointer
    // 030 IconTapInfoText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 VmList                                   000185D0C638 ModelClassListType List`1<StepUpGashaRatesPopupViewModel> List`1<StepUpGashaRatesPopupViewModel> List<StepUpGashaRatesPopupViewModel> Pointer
    // 040 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 050 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class StepUpGashaRatesPopupView : DataModel
    {
        public UITabGroup?                              UiTabGroup                              { get; set; }
        public StepUpGashaRateView?                     RateView                                { get; set; }
        public UITextMeshProUGUI?                       IconTapInfoText                         { get; set; }
        public List<StepUpGashaRatesPopupViewModel>?    VmList                                  { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static StepUpGashaRatesPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesPopupView() { Pointer= p0 };

            value.UiTabGroup                                = GetObject<UITabGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITabGroup.FromPointer); // 02466BA9AFF0 0x20 UiTabGroup                  ( 0001866F5490 ModelClassType UITabGroup UITabGroup UITabGroup Pointer )
            value.RateView                                  = GetObject<StepUpGashaRateView>(new IntPtr(p + 0x028), ReversePrism.DataModels.StepUpGashaRateView.FromPointer); // 02466BA9B010 0x28 RateView                    ( 000186589120 ModelClassType StepUpGashaRateView StepUpGashaRateView StepUpGashaRateView Pointer )
            value.IconTapInfoText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466BA9B030 0x30 IconTapInfoText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VmList                                    = GetObjectList<StepUpGashaRatesPopupViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.StepUpGashaRatesPopupViewModel.FromPointer); // 02466BA9B050 0x38 VmList                      ( 000185D0C638 ModelClassListType List`1<StepUpGashaRatesPopupViewModel> List`1<StepUpGashaRatesPopupViewModel> List<StepUpGashaRatesPopupViewModel> Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x048), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466BA9B090 0x48 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466BA9B0B0 0x50 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
