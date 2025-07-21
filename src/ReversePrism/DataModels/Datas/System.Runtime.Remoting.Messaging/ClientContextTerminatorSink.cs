using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Context                                  ModelClassType Context Context Context Pointer
    public partial class ClientContextTerminatorSink : DataModel
    {
        public Context?                                 Context                                 { get; set; }

        public static ClientContextTerminatorSink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClientContextTerminatorSink() { Pointer= p0 };

            value.Context                                   = GetObject<Context>(new IntPtr(p + 0x010), ReversePrism.DataModels.Context.FromPointer); // 0x10 Context                     ( ModelClassType Context Context Context Pointer )

            return value;
        }
    }
}
