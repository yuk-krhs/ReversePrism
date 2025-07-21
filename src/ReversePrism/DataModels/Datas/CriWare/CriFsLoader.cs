using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 handle                                   <int> IL2CPP_TYPE_I
    // 028 DstGch                                   ModelEnumType GCHandle GCHandle GCHandle Int32
    // 030 SrcGch                                   ModelEnumType GCHandle GCHandle GCHandle Int32
    public partial class CriFsLoader : DataModel
    {
        public GCHandle                                 DstGch                                  { get; set; }
        public GCHandle                                 SrcGch                                  { get; set; }

        public static CriFsLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsLoader() { Pointer= p0 };

            value.DstGch                                    = (GCHandle)GetInt32(new IntPtr(p + 0x028)); // 0x28 DstGch                      ( ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.SrcGch                                    = (GCHandle)GetInt32(new IntPtr(p + 0x030)); // 0x30 SrcGch                      ( ModelEnumType GCHandle GCHandle GCHandle Int32 )

            return value;
        }
    }
}
