using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ObjectName                               ModelPrimitiveType string string string String
    public partial class ObjectDisposedException : DataModel
    {
        public string                                   ObjectName                              { get; set; }

        public static ObjectDisposedException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectDisposedException() { Pointer= p0 };

            value.ObjectName                                = GetString(new IntPtr(p + 0x090)); // 0x90 ObjectName                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
