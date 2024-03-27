using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <Quality>k__BackingField                 Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 020 Value                                    000186671910 ModelPrimitiveType string string string String
    public partial class StringWithQualityHeaderValue
    {
        public string                                   Value                                   { get; set; }

        public static StringWithQualityHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringWithQualityHeaderValue();

            value.Value                                     = GetString(new IntPtr(p + 0x020)); // 0270DB89D7A0 0x20 Value                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
