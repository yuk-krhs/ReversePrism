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
    // 030 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 038 Vm                                       ModelClassType GashaRatesPopupViewModel GashaRatesPopupViewModel GashaRatesPopupViewModel Pointer
    public partial class GashaRateView : DataModel
    {
        public EnhancedScroller?                        Scroller                                { get; set; }
        public List<EnhancedScrollerCellView>?          CellViewPrefabs                         { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public GashaRatesPopupViewModel?                Vm                                      { get; set; }

        public static GashaRateView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRateView() { Pointer= p0 };

            value.Scroller                                  = GetObject<EnhancedScroller>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnhancedScroller.FromPointer); // 0x20 Scroller                    ( ModelClassType EnhancedScroller EnhancedScroller EnhancedScroller Pointer )
            value.CellViewPrefabs                           = GetObjectList<EnhancedScrollerCellView>(new IntPtr(p + 0x028), ReversePrism.DataModels.EnhancedScrollerCellView.FromPointer); // 0x28 CellViewPrefabs             ( ModelClassListType EnhancedScrollerCellView[] EnhancedScrollerCellView[] List<EnhancedScrollerCellView> Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x030), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x30 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Vm                                        = GetObject<GashaRatesPopupViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.GashaRatesPopupViewModel.FromPointer); // 0x38 Vm                          ( ModelClassType GashaRatesPopupViewModel GashaRatesPopupViewModel GashaRatesPopupViewModel Pointer )

            return value;
        }
    }
}
