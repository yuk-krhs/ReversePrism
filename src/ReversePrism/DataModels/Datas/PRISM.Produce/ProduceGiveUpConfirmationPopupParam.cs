using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 GiveupMessage                            0001866722E0 ModelPrimitiveType string string string String
    public partial class ProduceGiveUpConfirmationPopupParam
    {
        public string                                   GiveupMessage                           { get; set; }

        public static ProduceGiveUpConfirmationPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceGiveUpConfirmationPopupParam();

            value.GiveupMessage                             = GetString(new IntPtr(p + 0x090)); // 0270D5C83028 0x90 GiveupMessage               ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
