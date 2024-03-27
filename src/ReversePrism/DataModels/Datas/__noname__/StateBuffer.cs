using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HeaderIndex                              0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class StateBuffer
    {
        public int                                      HeaderIndex                             { get; set; }

        public static StateBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StateBuffer();

            value.HeaderIndex                               = GetInt32(new IntPtr(p + 0x010)); // 0270DB03E490 0x10 HeaderIndex                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
