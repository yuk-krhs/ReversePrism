using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 handle                                   <int> IL2CPP_TYPE_I
    // 028 DstGch                                   0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32
    // 030 SrcGch                                   0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32
    public partial class CriFsLoader
    {
        public GCHandle                                 DstGch                                  { get; set; }
        public GCHandle                                 SrcGch                                  { get; set; }

        public static CriFsLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriFsLoader();

            value.DstGch                                    = (GCHandle)GetInt32(new IntPtr(p + 0x028)); // 0270DAC7BF78 0x28 DstGch                      ( 0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.SrcGch                                    = (GCHandle)GetInt32(new IntPtr(p + 0x030)); // 0270DAC7BF98 0x30 SrcGch                      ( 0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32 )

            return value;
        }
    }
}
