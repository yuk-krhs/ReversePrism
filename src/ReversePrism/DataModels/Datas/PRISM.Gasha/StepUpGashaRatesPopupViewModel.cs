using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StepNo                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 014 ContentsType                             0001865F7B00 ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32
    // 018 CellViewModels                           000185CE8AB8 ModelClassListType List`1<IStepUpGashaRatesEnhancedScrollerCellViewModel> List`1<IStepUpGashaRatesEnhancedScrollerCellViewModel> List<IStepUpGashaRatesEnhancedScrollerCellViewModel> Pointer
    public partial class StepUpGashaRatesPopupViewModel : DataModel
    {
        public int                                      StepNo                                  { get; set; }
        public GashaContentsType                        ContentsType                            { get; set; }
        public List<IStepUpGashaRatesEnhancedScrollerCellViewModel>? CellViewModels                          { get; set; }

        public static StepUpGashaRatesPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesPopupViewModel() { Pointer= p0 };

            value.StepNo                                    = GetInt32(new IntPtr(p + 0x010)); // 0246653EF6A0 0x10 StepNo                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ContentsType                              = (GashaContentsType)GetInt32(new IntPtr(p + 0x014)); // 0246653EF6C0 0x14 ContentsType                ( 0001865F7B00 ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32 )
            value.CellViewModels                            = GetObjectList<IStepUpGashaRatesEnhancedScrollerCellViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStepUpGashaRatesEnhancedScrollerCellViewModel.FromPointer); // 0246653EF6E0 0x18 CellViewModels              ( 000185CE8AB8 ModelClassListType List`1<IStepUpGashaRatesEnhancedScrollerCellViewModel> List`1<IStepUpGashaRatesEnhancedScrollerCellViewModel> List<IStepUpGashaRatesEnhancedScrollerCellViewModel> Pointer )

            return value;
        }
    }
}
