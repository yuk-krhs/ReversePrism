using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_IsValid                                ModelPrimitiveType bool bool bool Bool
    // 014 Handle                                   ModelPrimitiveType int int int Int32
    public partial class RendererListHandle : DataModel
    {
        public bool                                     M_IsValid                               { get; set; }
        public int                                      Handle                                  { get; set; }

        public static RendererListHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RendererListHandle() { Pointer= p0 };

            value.M_IsValid                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 M_IsValid                   ( ModelPrimitiveType bool bool bool Bool )
            value.Handle                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Handle                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
