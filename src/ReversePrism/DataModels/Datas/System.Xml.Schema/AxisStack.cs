using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Stack                                    ModelClassType ArrayList ArrayList ArrayList Pointer
    // 018 Subtree                                  ModelClassType ForwardAxis ForwardAxis ForwardAxis Pointer
    // 020 Parent                                   ModelClassType ActiveAxis ActiveAxis ActiveAxis Pointer
    public partial class AxisStack : DataModel
    {
        public ArrayList?                               Stack                                   { get; set; }
        public ForwardAxis?                             Subtree                                 { get; set; }
        public ActiveAxis?                              Parent                                  { get; set; }

        public static AxisStack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AxisStack() { Pointer= p0 };

            value.Stack                                     = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0x10 Stack                       ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Subtree                                   = GetObject<ForwardAxis>(new IntPtr(p + 0x018), ReversePrism.DataModels.ForwardAxis.FromPointer); // 0x18 Subtree                     ( ModelClassType ForwardAxis ForwardAxis ForwardAxis Pointer )
            value.Parent                                    = GetObject<ActiveAxis>(new IntPtr(p + 0x020), ReversePrism.DataModels.ActiveAxis.FromPointer); // 0x20 Parent                      ( ModelClassType ActiveAxis ActiveAxis ActiveAxis Pointer )

            return value;
        }
    }
}
