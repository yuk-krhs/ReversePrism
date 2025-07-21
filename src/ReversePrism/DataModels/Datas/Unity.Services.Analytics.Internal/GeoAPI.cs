using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_PrivacyEndpoint                        ModelPrimitiveType string string string String
    public partial class GeoAPI : DataModel
    {
        public string                                   M_PrivacyEndpoint                       { get; set; }

        public static GeoAPI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GeoAPI() { Pointer= p0 };

            value.M_PrivacyEndpoint                         = GetString(new IntPtr(p + 0x010)); // 0x10 M_PrivacyEndpoint           ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
