using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 CultureName                              000186671910 ModelPrimitiveType string string string String
    public partial class MissingSatelliteAssemblyException
    {
        public string                                   CultureName                             { get; set; }

        public static MissingSatelliteAssemblyException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissingSatelliteAssemblyException();

            value.CultureName                               = GetString(new IntPtr(p + 0x090)); // 0270D6CC17F0 0x90 CultureName                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
