using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Lines                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class MultilineReactivePropertyAttribute
    {
        public int                                      Lines                                   { get; set; }

        public static MultilineReactivePropertyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultilineReactivePropertyAttribute();

            value.Lines                                     = GetInt32(new IntPtr(p + 0x010)); // 0270D95A4E48 0x10 Lines                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
