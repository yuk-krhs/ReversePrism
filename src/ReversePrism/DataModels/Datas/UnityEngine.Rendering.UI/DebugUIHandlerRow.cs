using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 M_Timer                                  0001866656B0 ModelPrimitiveType float float float Single
    public partial class DebugUIHandlerRow : DataModel
    {
        public float                                    M_Timer                                 { get; set; }

        public static DebugUIHandlerRow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerRow() { Pointer= p0 };

            value.M_Timer                                   = GetSingle(new IntPtr(p + 0x080)); // 02466939BAF0 0x80 M_Timer                     ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
