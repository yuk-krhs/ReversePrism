using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Level                                    000186666050 ModelPrimitiveType float float float Single
    public partial class Volume
    {
        public float                                    Level                                   { get; set; }

        public static Volume? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Volume();

            value.Level                                     = GetSingle(new IntPtr(p + 0x010)); // 0270DAC6E518 0x10 Level                       ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
