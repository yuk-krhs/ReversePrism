using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsListening                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DummyMessagingHandler
    {
        public bool                                     IsListening                             { get; set; }

        public static DummyMessagingHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DummyMessagingHandler();

            value.IsListening                               = GetBool(new IntPtr(p + 0x010)); // 027003AC2E00 0x10 IsListening                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
