using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rarity                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 018 RateList                                 000185D0CB78 ModelClassListType List`1<StepUpRateModel> List`1<StepUpRateModel> List<StepUpRateModel> Pointer
    // 020 PromisedRateName                         000186672F10 ModelPrimitiveType string string string String
    public partial class StepUpGashaRatesRateTableCellViewModel
    {
        public int                                      Rarity                                  { get; set; }
        public List<StepUpRateModel>?                   RateList                                { get; set; }
        public string                                   PromisedRateName                        { get; set; }

        public static StepUpGashaRatesRateTableCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesRateTableCellViewModel();

            value.Rarity                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D53FDF88 0x10 Rarity                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.RateList                                  = GetObjectList<StepUpRateModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.StepUpRateModel.FromPointer); // 0270D53FDFA8 0x18 RateList                    ( 000185D0CB78 ModelClassListType List`1<StepUpRateModel> List`1<StepUpRateModel> List<StepUpRateModel> Pointer )
            value.PromisedRateName                          = GetString(new IntPtr(p + 0x020)); // 0270D53FDFC8 0x20 PromisedRateName            ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
