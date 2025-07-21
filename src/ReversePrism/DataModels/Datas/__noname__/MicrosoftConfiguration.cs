using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseMock                                  ModelPrimitiveType bool bool bool Bool
    // 018 Module                                   ModelClassType StandardPurchasingModule StandardPurchasingModule StandardPurchasingModule Pointer
    public partial class MicrosoftConfiguration : DataModel
    {
        public bool                                     UseMock                                 { get; set; }
        public StandardPurchasingModule?                Module                                  { get; set; }

        public static MicrosoftConfiguration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MicrosoftConfiguration() { Pointer= p0 };

            value.UseMock                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 UseMock                     ( ModelPrimitiveType bool bool bool Bool )
            value.Module                                    = GetObject<StandardPurchasingModule>(new IntPtr(p + 0x018), ReversePrism.DataModels.StandardPurchasingModule.FromPointer); // 0x18 Module                      ( ModelClassType StandardPurchasingModule StandardPurchasingModule StandardPurchasingModule Pointer )

            return value;
        }
    }
}
