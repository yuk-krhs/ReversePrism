using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mode                                     00018662D590 ModelEnumType Mode Mode Mode Int32
    public partial class TrackballAttribute
    {
        public Mode                                     Mode                                    { get; set; }

        public static TrackballAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrackballAttribute();

            value.Mode                                      = (Mode)GetInt32(new IntPtr(p + 0x010)); // 0270DB41EBD0 0x10 Mode                        ( 00018662D590 ModelEnumType Mode Mode Mode Int32 )

            return value;
        }
    }
}
