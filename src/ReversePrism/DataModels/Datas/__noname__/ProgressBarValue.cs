using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 Min                                      000186666050 ModelPrimitiveType float float float Single
    // 064 Max                                      000186666050 ModelPrimitiveType float float float Single
    public partial class ProgressBarValue : DataModel
    {
        public float                                    Min                                     { get; set; }
        public float                                    Max                                     { get; set; }

        public static ProgressBarValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProgressBarValue() { Pointer= p0 };

            value.Min                                       = GetSingle(new IntPtr(p + 0x060)); // 0246691DC500 0x60 Min                         ( 000186666050 ModelPrimitiveType float float float Single )
            value.Max                                       = GetSingle(new IntPtr(p + 0x064)); // 0246691DC520 0x64 Max                         ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
