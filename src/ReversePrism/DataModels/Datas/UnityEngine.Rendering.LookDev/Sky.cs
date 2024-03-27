using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cubemap                                  000186661A90 ModelClassType Cubemap Cubemap Cubemap Pointer
    // 018 LongitudeOffset                          000186666050 ModelPrimitiveType float float float Single
    // 01C Exposure                                 000186666050 ModelPrimitiveType float float float Single
    public partial class Sky
    {
        public Cubemap?                                 Cubemap                                 { get; set; }
        public float                                    LongitudeOffset                         { get; set; }
        public float                                    Exposure                                { get; set; }

        public static Sky? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Sky();

            value.Cubemap                                   = GetObject<Cubemap>(new IntPtr(p + 0x010), ReversePrism.DataModels.Cubemap.FromPointer); // 0270D9303310 0x10 Cubemap                     ( 000186661A90 ModelClassType Cubemap Cubemap Cubemap Pointer )
            value.LongitudeOffset                           = GetSingle(new IntPtr(p + 0x018)); // 0270D9303330 0x18 LongitudeOffset             ( 000186666050 ModelPrimitiveType float float float Single )
            value.Exposure                                  = GetSingle(new IntPtr(p + 0x01C)); // 0270D9303350 0x1C Exposure                    ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
