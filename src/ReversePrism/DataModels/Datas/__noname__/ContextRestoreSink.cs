using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Next                                     0001865B0830 ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 018 Context                                  0001866134D0 ModelClassType Context Context Context Pointer
    // 020 Call                                     0001865AEA80 ModelClassType IMessage IMessage IMessage Pointer
    public partial class ContextRestoreSink
    {
        public IMessageSink?                            Next                                    { get; set; }
        public Context?                                 Context                                 { get; set; }
        public IMessage?                                Call                                    { get; set; }

        public static ContextRestoreSink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextRestoreSink();

            value.Next                                      = GetObject<IMessageSink>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMessageSink.FromPointer); // 0270D6BE3788 0x10 Next                        ( 0001865B0830 ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.Context                                   = GetObject<Context>(new IntPtr(p + 0x018), ReversePrism.DataModels.Context.FromPointer); // 0270D6BE37A8 0x18 Context                     ( 0001866134D0 ModelClassType Context Context Context Pointer )
            value.Call                                      = GetObject<IMessage>(new IntPtr(p + 0x020), ReversePrism.DataModels.IMessage.FromPointer); // 0270D6BE37C8 0x20 Call                        ( 0001865AEA80 ModelClassType IMessage IMessage IMessage Pointer )

            return value;
        }
    }
}
