using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RelativeAmount                           0001865F4940 ModelPrimitiveType int int int Int32
    public partial class Indent
    {
        public int                                      RelativeAmount                          { get; set; }

        public static Indent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Indent();

            value.RelativeAmount                            = GetInt32(new IntPtr(p + 0x010)); // 0270D92D2970 0x10 RelativeAmount              ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
