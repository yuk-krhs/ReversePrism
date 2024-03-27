using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MessageReceivedDelegate                  0001865125C0 ModelClassType MessageReceivedDelegate MessageReceivedDelegate MessageReceivedDelegate Pointer
    // 018 TokenReceivedDelegate                    000186512B00 ModelClassType TokenReceivedDelegate TokenReceivedDelegate TokenReceivedDelegate Pointer
    // 020 App                                      000186594D20 ModelClassType FirebaseApp FirebaseApp FirebaseApp Pointer
    // 000 listener                                 Listener IL2CPP_TYPE_CLASS
    public partial class Listener
    {
        public MessageReceivedDelegate?                 MessageReceivedDelegate                 { get; set; }
        public TokenReceivedDelegate?                   TokenReceivedDelegate                   { get; set; }
        public FirebaseApp?                             App                                     { get; set; }

        public static Listener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Listener();

            value.MessageReceivedDelegate                   = GetObject<MessageReceivedDelegate>(new IntPtr(p + 0x010), ReversePrism.DataModels.MessageReceivedDelegate.FromPointer); // 0270DBD883F0 0x10 MessageReceivedDelegate     ( 0001865125C0 ModelClassType MessageReceivedDelegate MessageReceivedDelegate MessageReceivedDelegate Pointer )
            value.TokenReceivedDelegate                     = GetObject<TokenReceivedDelegate>(new IntPtr(p + 0x018), ReversePrism.DataModels.TokenReceivedDelegate.FromPointer); // 0270DBD88410 0x18 TokenReceivedDelegate       ( 000186512B00 ModelClassType TokenReceivedDelegate TokenReceivedDelegate TokenReceivedDelegate Pointer )
            value.App                                       = GetObject<FirebaseApp>(new IntPtr(p + 0x020), ReversePrism.DataModels.FirebaseApp.FromPointer); // 0270DBD88430 0x20 App                         ( 000186594D20 ModelClassType FirebaseApp FirebaseApp FirebaseApp Pointer )

            return value;
        }
    }
}
