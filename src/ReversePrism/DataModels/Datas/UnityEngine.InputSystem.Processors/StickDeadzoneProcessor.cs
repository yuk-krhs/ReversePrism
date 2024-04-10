using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Min                                      000186666050 ModelPrimitiveType float float float Single
    // 014 Max                                      000186666050 ModelPrimitiveType float float float Single
    public partial class StickDeadzoneProcessor : DataModel
    {
        public float                                    Min                                     { get; set; }
        public float                                    Max                                     { get; set; }

        public static StickDeadzoneProcessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StickDeadzoneProcessor() { Pointer= p0 };

            value.Min                                       = GetSingle(new IntPtr(p + 0x010)); // 024667894378 0x10 Min                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.Max                                       = GetSingle(new IntPtr(p + 0x014)); // 024667894398 0x14 Max                         ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
