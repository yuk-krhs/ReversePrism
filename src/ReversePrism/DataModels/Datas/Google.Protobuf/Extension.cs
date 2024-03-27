using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FieldNumber                              0001865F4260 ModelPrimitiveType int int int Int32
    public partial class Extension
    {
        public int                                      FieldNumber                             { get; set; }

        public static Extension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Extension();

            value.FieldNumber                               = GetInt32(new IntPtr(p + 0x010)); // 0270D0B4A2D8 0x10 FieldNumber                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
