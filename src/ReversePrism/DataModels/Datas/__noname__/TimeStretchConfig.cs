using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reserved                                 ModelPrimitiveType int int int Int32
    public partial class TimeStretchConfig : DataModel
    {
        public int                                      Reserved                                { get; set; }

        public static TimeStretchConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeStretchConfig() { Pointer= p0 };

            value.Reserved                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 Reserved                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
