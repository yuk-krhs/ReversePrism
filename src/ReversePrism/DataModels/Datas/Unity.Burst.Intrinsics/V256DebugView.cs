using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  0001865F7AF0 ModelEnumType v256 v256 v256 Int32
    public partial class V256DebugView
    {
        public v256                                     M_Value                                 { get; set; }

        public static V256DebugView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new V256DebugView();

            value.M_Value                                   = (v256)GetInt32(new IntPtr(p + 0x010)); // 0270DA905D80 0x10 M_Value                     ( 0001865F7AF0 ModelEnumType v256 v256 v256 Int32 )

            return value;
        }
    }
}
