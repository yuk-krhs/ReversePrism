using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Scroller                                 ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer
    // 028 CellViewPrefabs                          ModelClassListType EnhancedScrollerCellView[] EnhancedScrollerCellView[] List<EnhancedScrollerCellView> Pointer
    // 030 ContentsType                             ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32
    // 038 PromisedRateName                         ModelPrimitiveType string string string String
    // 040 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 048 Vm                                       ModelClassType StepUpGashaRatesPopupViewModel StepUpGashaRatesPopupViewModel StepUpGashaRatesPopupViewModel Pointer
    public partial class StepUpGashaRateView : DataModel
    {
        public EnhancedScroller?                        Scroller                                { get; set; }
        public List<EnhancedScrollerCellView>?          CellViewPrefabs                         { get; set; }
        public GashaContentsType                        ContentsType                            { get; set; }
        public string                                   PromisedRateName                        { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public StepUpGashaRatesPopupViewModel?          Vm                                      { get; set; }

        public static StepUpGashaRateView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRateView() { Pointer= p0 };

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 0x20 Scroller                    ( ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.CellViewPrefabs                           = GetObjectList<EnhancedScrollerCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 0x28 CellViewPrefabs             ( ModelClassListType EnhancedScrollerCellView[] EnhancedScrollerCellView[] List<EnhancedScrollerCellView> Pointer )
            value.ContentsType                              = (GashaContentsType)GetInt32(new IntPtr(p + 0x030)); // 0x30 ContentsType                ( ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32 )
            value.PromisedRateName                          = GetString(new IntPtr(p + 0x038)); // 0x38 PromisedRateName            ( ModelPrimitiveType string string string String )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x040), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x40 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Vm                                        = GetObject<StepUpGashaRatesPopupViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.StepUpGashaRatesPopupViewModel.FromPointer); // 0x48 Vm                          ( ModelClassType StepUpGashaRatesPopupViewModel StepUpGashaRatesPopupViewModel StepUpGashaRatesPopupViewModel Pointer )

            return value;
        }
    }
}
