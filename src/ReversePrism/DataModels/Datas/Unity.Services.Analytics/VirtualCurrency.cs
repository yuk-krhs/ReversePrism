using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VirtualCurrencyName                      ModelPrimitiveType string string string String
    // 018 VirtualCurrencyType                      ModelEnumType VirtualCurrencyType VirtualCurrencyType VirtualCurrencyType Int32
    // 020 VirtualCurrencyAmount                    ModelPrimitiveType long long long Int64
    public partial class VirtualCurrency : DataModel
    {
        public string                                   VirtualCurrencyName                     { get; set; }
        public VirtualCurrencyType                      VirtualCurrencyType                     { get; set; }
        public long                                     VirtualCurrencyAmount                   { get; set; }

        public static VirtualCurrency? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VirtualCurrency() { Pointer= p0 };

            value.VirtualCurrencyName                       = GetString(new IntPtr(p + 0x010)); // 0x10 VirtualCurrencyName         ( ModelPrimitiveType string string string String )
            value.VirtualCurrencyType                       = (VirtualCurrencyType)GetInt32(new IntPtr(p + 0x018)); // 0x18 VirtualCurrencyType         ( ModelEnumType VirtualCurrencyType VirtualCurrencyType VirtualCurrencyType Int32 )
            value.VirtualCurrencyAmount                     = GetInt64(new IntPtr(p + 0x020)); // 0x20 VirtualCurrencyAmount       ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
