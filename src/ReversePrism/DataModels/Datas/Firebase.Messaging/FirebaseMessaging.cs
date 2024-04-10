using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MessageReceivedInternal                  EventHandler`1<MessageReceivedEventArgs> IL2CPP_TYPE_GENERICINST
    // 008 TokenReceivedInternal                    EventHandler`1<TokenReceivedEventArgs> IL2CPP_TYPE_GENERICINST
    // 010 Listener                                 0001866BA9B0 ModelClassType Listener Listener Listener Pointer
    public partial class FirebaseMessaging : DataModel
    {
        public Listener?                                Listener                                { get; set; }

        public static FirebaseMessaging? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FirebaseMessaging() { Pointer= p0 };

            value.Listener                                  = GetObject<Listener>(new IntPtr(p + 0x010), ReversePrism.DataModels.Listener.FromPointer); // 02466BE20C78 0x10 Listener                    ( 0001866BA9B0 ModelClassType Listener Listener Listener Pointer )

            return value;
        }
    }
}
