using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RarityRateList                           000185D0C938 ModelClassListType List`1<StepUpRarityRateModel> List`1<StepUpRarityRateModel> List<StepUpRarityRateModel> Pointer
    // 018 PromisedRateName                         000186672F10 ModelPrimitiveType string string string String
    public partial class StepUpGashaRatesRarityRateTableCellViewModel
    {
        public List<StepUpRarityRateModel>?             RarityRateList                          { get; set; }
        public string                                   PromisedRateName                        { get; set; }

        public static StepUpGashaRatesRarityRateTableCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesRarityRateTableCellViewModel();

            value.RarityRateList                            = GetObjectList<StepUpRarityRateModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.StepUpRarityRateModel.FromPointer); // 0270D53F9378 0x10 RarityRateList              ( 000185D0C938 ModelClassListType List`1<StepUpRarityRateModel> List`1<StepUpRarityRateModel> List<StepUpRarityRateModel> Pointer )
            value.PromisedRateName                          = GetString(new IntPtr(p + 0x018)); // 0270D53F9398 0x18 PromisedRateName            ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
