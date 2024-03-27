using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Width                                    000186666050 ModelPrimitiveType float float float Single
    // 014 Height                                   000186666050 ModelPrimitiveType float float float Single
    public partial class YogaSize
    {
        public float                                    Width                                   { get; set; }
        public float                                    Height                                  { get; set; }

        public static YogaSize? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new YogaSize();

            value.Width                                     = GetSingle(new IntPtr(p + 0x010)); // 0270066DE590 0x10 Width                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Height                                    = GetSingle(new IntPtr(p + 0x014)); // 0270066DE5B0 0x14 Height                      ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
