using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsScheduled                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 LowPriority                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ActionItem : DataModel
    {
        public bool                                     IsScheduled                             { get; set; }
        public bool                                     LowPriority                             { get; set; }

        public static ActionItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActionItem() { Pointer= p0 };

            value.IsScheduled                               = GetBool(new IntPtr(p + 0x010)); // 02466BAB0D88 0x10 IsScheduled                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LowPriority                               = GetBool(new IntPtr(p + 0x011)); // 02466BAB0DA8 0x11 LowPriority                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
