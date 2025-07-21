using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Called                                   ModelPrimitiveType bool bool bool Bool
    public partial class AsyncStartTrigger : DataModel
    {
        public bool                                     Called                                  { get; set; }

        public static AsyncStartTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncStartTrigger() { Pointer= p0 };

            value.Called                                    = GetBool(new IntPtr(p + 0x040)); // 0x40 Called                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
