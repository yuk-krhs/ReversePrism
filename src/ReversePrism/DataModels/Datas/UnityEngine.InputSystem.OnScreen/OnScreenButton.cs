using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 M_ControlPath                            000186671910 ModelPrimitiveType string string string String
    public partial class OnScreenButton
    {
        public string                                   M_ControlPath                           { get; set; }

        public static OnScreenButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OnScreenButton();

            value.M_ControlPath                             = GetString(new IntPtr(p + 0x038)); // 0270D77BC7C8 0x38 M_ControlPath               ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
