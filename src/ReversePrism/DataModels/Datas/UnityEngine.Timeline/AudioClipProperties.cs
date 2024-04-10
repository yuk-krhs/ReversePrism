using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Volume                                   000186666050 ModelPrimitiveType float float float Single
    public partial class AudioClipProperties : DataModel
    {
        public float                                    Volume                                  { get; set; }

        public static AudioClipProperties? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AudioClipProperties() { Pointer= p0 };

            value.Volume                                    = GetSingle(new IntPtr(p + 0x010)); // 02466B2CB180 0x10 Volume                      ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
