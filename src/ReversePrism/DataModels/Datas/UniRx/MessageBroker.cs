using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  IMessageBroker IL2CPP_TYPE_CLASS
    // 010 IsDisposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 notifiers                                Dictionary`2<Type, <object>> IL2CPP_TYPE_GENERICINST
    public partial class MessageBroker
    {
        public bool                                     IsDisposed                              { get; set; }

        public static MessageBroker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessageBroker();

            value.IsDisposed                                = GetBool(new IntPtr(p + 0x010)); // 0270D9551EF0 0x10 IsDisposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
