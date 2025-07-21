using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReplySink                                ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 018 Identity                                 ModelClassType ServerIdentity ServerIdentity ServerIdentity Pointer
    public partial class ServerObjectReplySink : DataModel
    {
        public IMessageSink?                            ReplySink                               { get; set; }
        public ServerIdentity?                          Identity                                { get; set; }

        public static ServerObjectReplySink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServerObjectReplySink() { Pointer= p0 };

            value.ReplySink                                 = GetObject<IMessageSink>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMessageSink.FromPointer); // 0x10 ReplySink                   ( ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.Identity                                  = GetObject<ServerIdentity>(new IntPtr(p + 0x018), ReversePrism.DataModels.ServerIdentity.FromPointer); // 0x18 Identity                    ( ModelClassType ServerIdentity ServerIdentity ServerIdentity Pointer )

            return value;
        }
    }
}
