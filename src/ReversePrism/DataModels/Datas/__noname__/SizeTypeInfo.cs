using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Height                                   000186666050 ModelPrimitiveType float float float Single
    // 014 Width                                    000186666050 ModelPrimitiveType float float float Single
    public partial class SizeTypeInfo
    {
        public float                                    Height                                  { get; set; }
        public float                                    Width                                   { get; set; }

        public static SizeTypeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SizeTypeInfo();

            value.Height                                    = GetSingle(new IntPtr(p + 0x010)); // 0270DB55CD88 0x10 Height                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Width                                     = GetSingle(new IntPtr(p + 0x014)); // 0270DB55CDA8 0x14 Width                       ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
