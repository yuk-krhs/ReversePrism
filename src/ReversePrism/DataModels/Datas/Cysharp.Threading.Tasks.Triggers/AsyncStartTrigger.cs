using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 Called                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AsyncStartTrigger
    {
        public bool                                     Called                                  { get; set; }

        public static AsyncStartTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncStartTrigger();

            value.Called                                    = GetBool(new IntPtr(p + 0x048)); // 0270D8FBB928 0x48 Called                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
