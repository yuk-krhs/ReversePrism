using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AiComboModel                             ModelClassType AiComboModel AiComboModel AiComboModel Pointer
    // 018 AiScoreRateData                          ModelClassType AiScoreRateData AiScoreRateData AiScoreRateData Pointer
    public partial class AiTestDataCreateModel : DataModel
    {
        public AiComboModel?                            AiComboModel                            { get; set; }
        public AiScoreRateData?                         AiScoreRateData                         { get; set; }

        public static AiTestDataCreateModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiTestDataCreateModel() { Pointer= p0 };

            value.AiComboModel                              = GetObject<AiComboModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.AiComboModel.FromPointer); // 0x10 AiComboModel                ( ModelClassType AiComboModel AiComboModel AiComboModel Pointer )
            value.AiScoreRateData                           = GetObject<AiScoreRateData>(new IntPtr(p + 0x018), ReversePrism.DataModels.AiScoreRateData.FromPointer); // 0x18 AiScoreRateData             ( ModelClassType AiScoreRateData AiScoreRateData AiScoreRateData Pointer )

            return value;
        }
    }
}
