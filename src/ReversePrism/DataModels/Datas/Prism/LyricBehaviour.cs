using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Text                                     0001866722E0 ModelPrimitiveType string string string String
    public partial class LyricBehaviour
    {
        public string                                   Text                                    { get; set; }

        public static LyricBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LyricBehaviour();

            value.Text                                      = GetString(new IntPtr(p + 0x010)); // 0270D4DFE560 0x10 Text                        ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
