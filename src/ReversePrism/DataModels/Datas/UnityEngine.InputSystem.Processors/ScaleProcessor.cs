using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Factor                                   000186666050 ModelPrimitiveType float float float Single
    public partial class ScaleProcessor
    {
        public float                                    Factor                                  { get; set; }

        public static ScaleProcessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScaleProcessor();

            value.Factor                                    = GetSingle(new IntPtr(p + 0x010)); // 0270D783BF28 0x10 Factor                      ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
