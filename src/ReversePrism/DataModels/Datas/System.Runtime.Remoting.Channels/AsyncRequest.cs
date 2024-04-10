using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReplySink                                0001865B0AA0 ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 018 MsgRequest                               0001865AECF0 ModelClassType IMessage IMessage IMessage Pointer
    public partial class AsyncRequest : DataModel
    {
        public IMessageSink?                            ReplySink                               { get; set; }
        public IMessage?                                MsgRequest                              { get; set; }

        public static AsyncRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncRequest() { Pointer= p0 };

            value.ReplySink                                 = GetObject<IMessageSink>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMessageSink.FromPointer); // 024666C5DC88 0x10 ReplySink                   ( 0001865B0AA0 ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.MsgRequest                                = GetObject<IMessage>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMessage.FromPointer); // 024666C5DCA8 0x18 MsgRequest                  ( 0001865AECF0 ModelClassType IMessage IMessage IMessage Pointer )

            return value;
        }
    }
}
