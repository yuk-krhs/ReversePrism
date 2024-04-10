using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DoesNotContributeToSize                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class IgnoreAttribute : DataModel
    {
        public bool                                     DoesNotContributeToSize                 { get; set; }

        public static IgnoreAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IgnoreAttribute() { Pointer= p0 };

            value.DoesNotContributeToSize                   = GetBool(new IntPtr(p + 0x010)); // 0245A692C318 0x10 DoesNotContributeToSize     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
