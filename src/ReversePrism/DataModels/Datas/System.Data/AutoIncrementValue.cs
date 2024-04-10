using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Auto                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AutoIncrementValue : DataModel
    {
        public bool                                     Auto                                    { get; set; }

        public static AutoIncrementValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoIncrementValue() { Pointer= p0 };

            value.Auto                                      = GetBool(new IntPtr(p + 0x010)); // 024668921D58 0x10 Auto                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
