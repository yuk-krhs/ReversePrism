using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetName                               000186672F10 ModelPrimitiveType string string string String
    // 018 PeerPem                                  000186672F10 ModelPrimitiveType string string string String
    public partial class VerifyPeerContext
    {
        public string                                   TargetName                              { get; set; }
        public string                                   PeerPem                                 { get; set; }

        public static VerifyPeerContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyPeerContext();

            value.TargetName                                = GetString(new IntPtr(p + 0x010)); // 0270DBB5F938 0x10 TargetName                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.PeerPem                                   = GetString(new IntPtr(p + 0x018)); // 0270DBB5F958 0x18 PeerPem                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
