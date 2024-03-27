using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ObjectName                               000186671910 ModelPrimitiveType string string string String
    public partial class ObjectDisposedException
    {
        public string                                   ObjectName                              { get; set; }

        public static ObjectDisposedException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectDisposedException();

            value.ObjectName                                = GetString(new IntPtr(p + 0x090)); // 0270D69EEFE8 0x90 ObjectName                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
