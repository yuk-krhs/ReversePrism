using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Message                                  000186597830 ModelClassType FirebaseMessage FirebaseMessage FirebaseMessage Pointer
    public partial class MessageReceivedEventArgs : DataModel
    {
        public FirebaseMessage?                         Message                                 { get; set; }

        public static MessageReceivedEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessageReceivedEventArgs() { Pointer= p0 };

            value.Message                                   = GetObject<FirebaseMessage>(new IntPtr(p + 0x010), ReversePrism.DataModels.FirebaseMessage.FromPointer); // 02466BE0B678 0x10 Message                     ( 000186597830 ModelClassType FirebaseMessage FirebaseMessage FirebaseMessage Pointer )

            return value;
        }
    }
}
