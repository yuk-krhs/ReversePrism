using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 InnerStream                              ModelClassType Stream Stream Stream Pointer
    // 030 LeaveStreamOpen                          ModelPrimitiveType bool bool bool Bool
    public partial class AuthenticatedStream : DataModel
    {
        public Stream?                                  InnerStream                             { get; set; }
        public bool                                     LeaveStreamOpen                         { get; set; }

        public static AuthenticatedStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthenticatedStream() { Pointer= p0 };

            value.InnerStream                               = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 0x28 InnerStream                 ( ModelClassType Stream Stream Stream Pointer )
            value.LeaveStreamOpen                           = GetBool(new IntPtr(p + 0x030)); // 0x30 LeaveStreamOpen             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
