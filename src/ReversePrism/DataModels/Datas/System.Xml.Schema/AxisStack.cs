using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Stack                                    00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 018 Subtree                                  0001865BAD20 ModelClassType ForwardAxis ForwardAxis ForwardAxis Pointer
    // 020 Parent                                   00018667FA80 ModelClassType ActiveAxis ActiveAxis ActiveAxis Pointer
    public partial class AxisStack
    {
        public ArrayList?                               Stack                                   { get; set; }
        public ForwardAxis?                             Subtree                                 { get; set; }
        public ActiveAxis?                              Parent                                  { get; set; }

        public static AxisStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AxisStack();

            value.Stack                                     = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D74D5118 0x10 Stack                       ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Subtree                                   = GetObject<ForwardAxis>(new IntPtr(p + 0x018), ReversePrism.DataModels.ForwardAxis.FromPointer); // 0270D74D5138 0x18 Subtree                     ( 0001865BAD20 ModelClassType ForwardAxis ForwardAxis ForwardAxis Pointer )
            value.Parent                                    = GetObject<ActiveAxis>(new IntPtr(p + 0x020), ReversePrism.DataModels.ActiveAxis.FromPointer); // 0270D74D5158 0x20 Parent                      ( 00018667FA80 ModelClassType ActiveAxis ActiveAxis ActiveAxis Pointer )

            return value;
        }
    }
}
