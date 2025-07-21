using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Handle                                 ModelPrimitiveType int int int Int32
    public partial class Cache : DataModel
    {
        public int                                      M_Handle                                { get; set; }

        public static Cache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Cache() { Pointer= p0 };

            value.M_Handle                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Handle                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
