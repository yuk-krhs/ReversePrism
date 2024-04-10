using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VerifyPeerCallback                       00018650C6F0 ModelClassType VerifyPeerCallback VerifyPeerCallback VerifyPeerCallback Pointer
    // 018 CallbackRegistration                     000186683340 ModelClassType NativeCallbackRegistration NativeCallbackRegistration NativeCallbackRegistration Pointer
    public partial class VerifyPeerCallbackRegistration : DataModel
    {
        public VerifyPeerCallback?                      VerifyPeerCallback                      { get; set; }
        public NativeCallbackRegistration?              CallbackRegistration                    { get; set; }

        public static VerifyPeerCallbackRegistration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyPeerCallbackRegistration() { Pointer= p0 };

            value.VerifyPeerCallback                        = GetObject<VerifyPeerCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.VerifyPeerCallback.FromPointer); // 0245A414FFC0 0x10 VerifyPeerCallback          ( 00018650C6F0 ModelClassType VerifyPeerCallback VerifyPeerCallback VerifyPeerCallback Pointer )
            value.CallbackRegistration                      = GetObject<NativeCallbackRegistration>(new IntPtr(p + 0x018), ReversePrism.DataModels.NativeCallbackRegistration.FromPointer); // 0245A414FFE0 0x18 CallbackRegistration        ( 000186683340 ModelClassType NativeCallbackRegistration NativeCallbackRegistration NativeCallbackRegistration Pointer )

            return value;
        }
    }
}
