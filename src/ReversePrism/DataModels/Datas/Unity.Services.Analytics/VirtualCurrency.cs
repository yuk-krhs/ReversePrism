using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VirtualCurrencyName                      0001866722E0 ModelPrimitiveType string string string String
    // 018 VirtualCurrencyType                      000186526190 ModelEnumType VirtualCurrencyType VirtualCurrencyType VirtualCurrencyType Int32
    // 020 VirtualCurrencyAmount                    0001865F7E40 ModelPrimitiveType long long long Int64
    public partial class VirtualCurrency
    {
        public string                                   VirtualCurrencyName                     { get; set; }
        public VirtualCurrencyType                      VirtualCurrencyType                     { get; set; }
        public long                                     VirtualCurrencyAmount                   { get; set; }

        public static VirtualCurrency? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VirtualCurrency();

            value.VirtualCurrencyName                       = GetString(new IntPtr(p + 0x010)); // 0270DB7B0E20 0x10 VirtualCurrencyName         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.VirtualCurrencyType                       = (VirtualCurrencyType)GetInt32(new IntPtr(p + 0x018)); // 0270DB7B0E40 0x18 VirtualCurrencyType         ( 000186526190 ModelEnumType VirtualCurrencyType VirtualCurrencyType VirtualCurrencyType Int32 )
            value.VirtualCurrencyAmount                     = GetInt64(new IntPtr(p + 0x020)); // 0270DB7B0E60 0x20 VirtualCurrencyAmount       ( 0001865F7E40 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
