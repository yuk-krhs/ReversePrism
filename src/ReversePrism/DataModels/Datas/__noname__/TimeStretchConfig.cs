using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reserved                                 0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class TimeStretchConfig
    {
        public int                                      Reserved                                { get; set; }

        public static TimeStretchConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeStretchConfig();

            value.Reserved                                  = GetInt32(new IntPtr(p + 0x010)); // 0270DAC79DE0 0x10 Reserved                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
