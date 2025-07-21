using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rarity                                   ModelPrimitiveType int int int Int32
    // 018 RateList                                 ModelClassListType List`1<StepUpRateModel> List`1<StepUpRateModel> List<StepUpRateModel> Pointer
    // 020 PromisedRateName                         ModelPrimitiveType string string string String
    public partial class StepUpGashaRatesRateTableCellViewModel : DataModel
    {
        public int                                      Rarity                                  { get; set; }
        public List<StepUpRateModel>?                   RateList                                { get; set; }
        public string                                   PromisedRateName                        { get; set; }

        public static StepUpGashaRatesRateTableCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesRateTableCellViewModel() { Pointer= p0 };

            value.Rarity                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Rarity                      ( ModelPrimitiveType int int int Int32 )
            value.RateList                                  = GetObjectList<StepUpRateModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StepUpRateModel.FromPointer); // 0x18 RateList                    ( ModelClassListType List`1<StepUpRateModel> List`1<StepUpRateModel> List<StepUpRateModel> Pointer )
            value.PromisedRateName                          = GetString(new IntPtr(p + 0x020)); // 0x20 PromisedRateName            ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
