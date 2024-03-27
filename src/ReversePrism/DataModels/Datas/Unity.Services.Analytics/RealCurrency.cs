using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RealCurrencyType                         0001866722E0 ModelPrimitiveType string string string String
    // 018 RealCurrencyAmount                       0001865F7E40 ModelPrimitiveType long long long Int64
    public partial class RealCurrency
    {
        public string                                   RealCurrencyType                        { get; set; }
        public long                                     RealCurrencyAmount                      { get; set; }

        public static RealCurrency? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RealCurrency();

            value.RealCurrencyType                          = GetString(new IntPtr(p + 0x010)); // 0270DB79D778 0x10 RealCurrencyType            ( 0001866722E0 ModelPrimitiveType string string string String )
            value.RealCurrencyAmount                        = GetInt64(new IntPtr(p + 0x018)); // 0270DB79D798 0x18 RealCurrencyAmount          ( 0001865F7E40 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
