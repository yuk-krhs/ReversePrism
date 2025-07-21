using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 none                                     ShaderTagId IL2CPP_TYPE_VALUETYPE
    // 010 M_Id                                     ModelPrimitiveType int int int Int32
    public partial class ShaderTagId : DataModel
    {
        public int                                      M_Id                                    { get; set; }

        public static ShaderTagId? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderTagId() { Pointer= p0 };

            value.M_Id                                      = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Id                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
