using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_IsValid                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 Handle                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class RendererListHandle
    {
        public bool                                     M_IsValid                               { get; set; }
        public int                                      Handle                                  { get; set; }

        public static RendererListHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererListHandle();

            value.M_IsValid                                 = GetBool(new IntPtr(p + 0x010)); // 0270D909ECC0 0x10 M_IsValid                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Handle                                    = GetInt32(new IntPtr(p + 0x014)); // 0270D909ECE0 0x14 Handle                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
