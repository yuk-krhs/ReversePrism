using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ContentsType                             ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32
    // 018 PromisedRateName                         ModelPrimitiveType string string string String
    // 020 CellViewModels                           ModelClassListType List`1<IGashaRatesEnhancedScrollerCellViewModel> List`1<IGashaRatesEnhancedScrollerCellViewModel> List<IGashaRatesEnhancedScrollerCellViewModel> Pointer
    public partial class GashaRatesPopupViewModel : DataModel
    {
        public GashaContentsType                        ContentsType                            { get; set; }
        public string                                   PromisedRateName                        { get; set; }
        public List<IGashaRatesEnhancedScrollerCellViewModel>? CellViewModels                          { get; set; }

        public static GashaRatesPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRatesPopupViewModel() { Pointer= p0 };

            value.ContentsType                              = (GashaContentsType)GetInt32(new IntPtr(p + 0x010)); // 0x10 ContentsType                ( ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32 )
            value.PromisedRateName                          = GetString(new IntPtr(p + 0x018)); // 0x18 PromisedRateName            ( ModelPrimitiveType string string string String )
            value.CellViewModels                            = GetObjectList<IGashaRatesEnhancedScrollerCellViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IGashaRatesEnhancedScrollerCellViewModel.FromPointer); // 0x20 CellViewModels              ( ModelClassListType List`1<IGashaRatesEnhancedScrollerCellViewModel> List`1<IGashaRatesEnhancedScrollerCellViewModel> List<IGashaRatesEnhancedScrollerCellViewModel> Pointer )

            return value;
        }
    }
}
