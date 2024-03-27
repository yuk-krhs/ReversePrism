using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReplySink                                0001865B0830 ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 018 Context                                  0001866134D0 ModelClassType Context Context Context Pointer
    public partial class ClientContextReplySink
    {
        public IMessageSink?                            ReplySink                               { get; set; }
        public Context?                                 Context                                 { get; set; }

        public static ClientContextReplySink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClientContextReplySink();

            value.ReplySink                                 = GetObject<IMessageSink>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMessageSink.FromPointer); // 0270D6BE8F80 0x10 ReplySink                   ( 0001865B0830 ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.Context                                   = GetObject<Context>(new IntPtr(p + 0x018), ReversePrism.DataModels.Context.FromPointer); // 0270D6BE8FA0 0x18 Context                     ( 0001866134D0 ModelClassType Context Context Context Pointer )

            return value;
        }
    }
}
