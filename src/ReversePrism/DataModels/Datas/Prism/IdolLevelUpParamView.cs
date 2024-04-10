using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ValueText                                0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 028 AddValueText                             0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 030 Format                                   000186671910 ModelPrimitiveType string string string String
    public partial class IdolLevelUpParamView : DataModel
    {
        public TextMeshProUGUI?                         ValueText                               { get; set; }
        public TextMeshProUGUI?                         AddValueText                            { get; set; }
        public string                                   Format                                  { get; set; }

        public static IdolLevelUpParamView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolLevelUpParamView() { Pointer= p0 };

            value.ValueText                                 = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 024664CCBCB0 0x20 ValueText                   ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.AddValueText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 024664CCBCD0 0x28 AddValueText                ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.Format                                    = GetString(new IntPtr(p + 0x030)); // 024664CCBCF0 0x30 Format                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
