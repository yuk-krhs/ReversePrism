using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Seconds                                  0001866656B0 ModelPrimitiveType float float float Single
    public partial class WaitSecondsSequence : DataModel
    {
        public float                                    Seconds                                 { get; set; }

        public static WaitSecondsSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WaitSecondsSequence() { Pointer= p0 };

            value.Seconds                                   = GetSingle(new IntPtr(p + 0x010)); // 0245A5743DF0 0x10 Seconds                     ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
