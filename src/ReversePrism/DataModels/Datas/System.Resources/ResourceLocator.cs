using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _value                                   <object> IL2CPP_TYPE_OBJECT
    // 018 DataPos                                  0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class ResourceLocator
    {
        public int                                      DataPos                                 { get; set; }

        public static ResourceLocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceLocator();

            value.DataPos                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D6CC5B28 0x18 DataPos                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
