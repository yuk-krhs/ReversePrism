using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 CellViewPrefabs                          000185B7B660 ModelClassListType EnhancedScrollerCellView[] EnhancedScrollerCellView[] List<EnhancedScrollerCellView> Pointer
    // 030 ContentsType                             0001865F7620 ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32
    // 038 PromisedRateName                         000186671910 ModelPrimitiveType string string string String
    // 040 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 048 Vm                                       00018658ADB0 ModelClassType StepUpGashaRatesPopupViewModel StepUpGashaRatesPopupViewModel StepUpGashaRatesPopupViewModel Pointer
    public partial class StepUpGashaRateView
    {
        public EnhancedScroller?                        Scroller                                { get; set; }
        public List<EnhancedScrollerCellView>?          CellViewPrefabs                         { get; set; }
        public GashaContentsType                        ContentsType                            { get; set; }
        public string                                   PromisedRateName                        { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public StepUpGashaRatesPopupViewModel?          Vm                                      { get; set; }

        public static StepUpGashaRateView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRateView();

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 0270DBA140F0 0x20 Scroller                    ( 000186735270 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.CellViewPrefabs                           = GetObjectList<EnhancedScrollerCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 0270DBA14110 0x28 CellViewPrefabs             ( 000185B7B660 ModelClassListType EnhancedScrollerCellView[] EnhancedScrollerCellView[] List<EnhancedScrollerCellView> Pointer )
            value.ContentsType                              = (GashaContentsType)GetInt32(new IntPtr(p + 0x030)); // 0270DBA14130 0x30 ContentsType                ( 0001865F7620 ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32 )
            value.PromisedRateName                          = GetString(new IntPtr(p + 0x038)); // 0270DBA14150 0x38 PromisedRateName            ( 000186671910 ModelPrimitiveType string string string String )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x040), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DBA14170 0x40 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Vm                                        = GetObject<StepUpGashaRatesPopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.StepUpGashaRatesPopupViewModel.FromPointer); // 0270DBA14190 0x48 Vm                          ( 00018658ADB0 ModelClassType StepUpGashaRatesPopupViewModel StepUpGashaRatesPopupViewModel StepUpGashaRatesPopupViewModel Pointer )

            return value;
        }
    }
}
