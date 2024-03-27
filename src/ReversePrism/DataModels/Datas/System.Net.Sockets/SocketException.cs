using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 098 M_EndPoint                               0001865C6810 ModelClassType EndPoint EndPoint EndPoint Pointer
    public partial class SocketException
    {
        public EndPoint?                                M_EndPoint                              { get; set; }

        public static SocketException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SocketException();

            value.M_EndPoint                                = GetObject<EndPoint>(new IntPtr(p + 0x098), ReversePrism.DataModels.EndPoint.FromPointer); // 0270D7AEC000 0x98 M_EndPoint                  ( 0001865C6810 ModelClassType EndPoint EndPoint EndPoint Pointer )

            return value;
        }
    }
}
