using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RealCurrencyType                         ModelPrimitiveType string string string String
    // 018 RealCurrencyAmount                       ModelPrimitiveType long long long Int64
    public partial class RealCurrency : DataModel
    {
        public string                                   RealCurrencyType                        { get; set; }
        public long                                     RealCurrencyAmount                      { get; set; }

        public static RealCurrency? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RealCurrency() { Pointer= p0 };

            value.RealCurrencyType                          = GetString(new IntPtr(p + 0x010)); // 0x10 RealCurrencyType            ( ModelPrimitiveType string string string String )
            value.RealCurrencyAmount                        = GetInt64(new IntPtr(p + 0x018)); // 0x18 RealCurrencyAmount          ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
