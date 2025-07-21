using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Val                                      ModelPrimitiveType bool bool bool Bool
    public partial class ComVisibleAttribute : DataModel
    {
        public bool                                     Val                                     { get; set; }

        public static ComVisibleAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ComVisibleAttribute() { Pointer= p0 };

            value.Val                                       = GetBool(new IntPtr(p + 0x010)); // 0x10 Val                         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
