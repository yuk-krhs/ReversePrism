using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Invalid                                  int IL2CPP_TYPE_I4
    // 010 Handle                                   ModelPrimitiveType int int int Int32
    public partial class PQHandle : DataModel
    {
        public int                                      Handle                                  { get; set; }

        public static PQHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PQHandle() { Pointer= p0 };

            value.Handle                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 Handle                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
