using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 InnerStream                              000186670270 ModelClassType Stream Stream Stream Pointer
    // 030 LeaveStreamOpen                          000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AuthenticatedStream
    {
        public Stream?                                  InnerStream                             { get; set; }
        public bool                                     LeaveStreamOpen                         { get; set; }

        public static AuthenticatedStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthenticatedStream();

            value.InnerStream                               = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 0270D78EEEC8 0x28 InnerStream                 ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.LeaveStreamOpen                           = GetBool(new IntPtr(p + 0x030)); // 0270D78EEEE8 0x30 LeaveStreamOpen             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
