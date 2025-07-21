using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _token                                   <int> IL2CPP_TYPE_I
    // 018 Undo                                     ModelPrimitiveType bool bool bool Bool
    public partial class WindowsImpersonationContext : DataModel
    {
        public bool                                     Undo                                    { get; set; }

        public static WindowsImpersonationContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WindowsImpersonationContext() { Pointer= p0 };

            value.Undo                                      = GetBool(new IntPtr(p + 0x018)); // 0x18 Undo                        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
