using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AiComboModel                             00018669C100 ModelClassType AiComboModel AiComboModel AiComboModel Pointer
    // 018 AiScoreRateData                          00018669E560 ModelClassType AiScoreRateData AiScoreRateData AiScoreRateData Pointer
    // 000 TagName                                  string IL2CPP_TYPE_STRING
    public partial class AiTestDataCreateModel
    {
        public AiComboModel?                            AiComboModel                            { get; set; }
        public AiScoreRateData?                         AiScoreRateData                         { get; set; }

        public static AiTestDataCreateModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiTestDataCreateModel();

            value.AiComboModel                              = GetObject<AiComboModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.AiComboModel.FromPointer); // 0270D5A94600 0x10 AiComboModel                ( 00018669C100 ModelClassType AiComboModel AiComboModel AiComboModel Pointer )
            value.AiScoreRateData                           = GetObject<AiScoreRateData>(new IntPtr(p + 0x018), ReversePrism.DataModels.AiScoreRateData.FromPointer); // 0270D5A94620 0x18 AiScoreRateData             ( 00018669E560 ModelClassType AiScoreRateData AiScoreRateData AiScoreRateData Pointer )

            return value;
        }
    }
}
