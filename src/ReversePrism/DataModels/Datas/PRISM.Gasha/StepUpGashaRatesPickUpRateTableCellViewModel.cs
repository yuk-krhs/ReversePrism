using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rarity                                   ModelPrimitiveType int int int Int32
    // 018 PickUpRateList                           ModelClassListType List`1<GashaRatesRateProductCellViewModel> List`1<GashaRatesRateProductCellViewModel> List<GashaRatesRateProductCellViewModel> Pointer
    // 020 PromisedRateName                         ModelPrimitiveType string string string String
    public partial class StepUpGashaRatesPickUpRateTableCellViewModel : DataModel
    {
        public int                                      Rarity                                  { get; set; }
        public List<GashaRatesRateProductCellViewModel>? PickUpRateList                          { get; set; }
        public string                                   PromisedRateName                        { get; set; }

        public static StepUpGashaRatesPickUpRateTableCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesPickUpRateTableCellViewModel() { Pointer= p0 };

            value.Rarity                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Rarity                      ( ModelPrimitiveType int int int Int32 )
            value.PickUpRateList                            = GetObjectList<GashaRatesRateProductCellViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaRatesRateProductCellViewModel.FromPointer); // 0x18 PickUpRateList              ( ModelClassListType List`1<GashaRatesRateProductCellViewModel> List`1<GashaRatesRateProductCellViewModel> List<GashaRatesRateProductCellViewModel> Pointer )
            value.PromisedRateName                          = GetString(new IntPtr(p + 0x020)); // 0x20 PromisedRateName            ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
