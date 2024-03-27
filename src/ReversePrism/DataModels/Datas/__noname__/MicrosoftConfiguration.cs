using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseMock                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Module                                   00018656CDE0 ModelClassType StandardPurchasingModule StandardPurchasingModule StandardPurchasingModule Pointer
    public partial class MicrosoftConfiguration
    {
        public bool                                     UseMock                                 { get; set; }
        public StandardPurchasingModule?                Module                                  { get; set; }

        public static MicrosoftConfiguration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MicrosoftConfiguration();

            value.UseMock                                   = GetBool(new IntPtr(p + 0x010)); // 02700691C330 0x10 UseMock                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Module                                    = GetObject<StandardPurchasingModule>(new IntPtr(p + 0x018), ReversePrism.DataModels.StandardPurchasingModule.FromPointer); // 02700691C350 0x18 Module                      ( 00018656CDE0 ModelClassType StandardPurchasingModule StandardPurchasingModule StandardPurchasingModule Pointer )

            return value;
        }
    }
}
