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
    public partial class VerifyPeerContext : DataModel
    {
        public string                                   TargetName                              { get; set; }
        public string                                   PeerPem                                 { get; set; }

        public static VerifyPeerContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VerifyPeerContext() { Pointer= p0 };

            value.TargetName                                = GetString(new IntPtr(p + 0x010)); // 02466BBE7778 0x10 TargetName                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.PeerPem                                   = GetString(new IntPtr(p + 0x018)); // 02466BBE7798 0x18 PeerPem                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
