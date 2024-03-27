using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Version                                  000186672F10 ModelPrimitiveType string string string String
    public partial class SatelliteContractVersionAttribute
    {
        public string                                   Version                                 { get; set; }

        public static SatelliteContractVersionAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SatelliteContractVersionAttribute();

            value.Version                                   = GetString(new IntPtr(p + 0x010)); // 0270D6CC8918 0x10 Version                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
