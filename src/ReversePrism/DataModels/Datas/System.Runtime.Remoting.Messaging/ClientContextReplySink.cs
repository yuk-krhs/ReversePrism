using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReplySink                                ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 018 Context                                  ModelClassType Context Context Context Pointer
    public partial class ClientContextReplySink : DataModel
    {
        public IMessageSink?                            ReplySink                               { get; set; }
        public Context?                                 Context                                 { get; set; }

        public static ClientContextReplySink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClientContextReplySink() { Pointer= p0 };

            value.ReplySink                                 = GetObject<IMessageSink>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMessageSink.FromPointer); // 0x10 ReplySink                   ( ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.Context                                   = GetObject<Context>(new IntPtr(p + 0x018), ReversePrism.DataModels.Context.FromPointer); // 0x18 Context                     ( ModelClassType Context Context Context Pointer )

            return value;
        }
    }
}
