using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Context                                  0001866134D0 ModelClassType Context Context Context Pointer
    public partial class ClientContextTerminatorSink
    {
        public Context?                                 Context                                 { get; set; }

        public static ClientContextTerminatorSink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClientContextTerminatorSink();

            value.Context                                   = GetObject<Context>(new IntPtr(p + 0x010), ReversePrism.DataModels.Context.FromPointer); // 0270D6BE8E20 0x10 Context                     ( 0001866134D0 ModelClassType Context Context Context Pointer )

            return value;
        }
    }
}
