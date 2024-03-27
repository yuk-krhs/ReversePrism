using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _token                                   <int> IL2CPP_TYPE_I
    // 018 Undo                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class WindowsImpersonationContext
    {
        public bool                                     Undo                                    { get; set; }

        public static WindowsImpersonationContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WindowsImpersonationContext();

            value.Undo                                      = GetBool(new IntPtr(p + 0x018)); // 0270D6BB1BD8 0x18 Undo                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
