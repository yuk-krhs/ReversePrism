using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Min                                      0001865F59B0 ModelPrimitiveType int int int Int32
    public partial class MinIntParameter : DataModel
    {
        public int                                      Min                                     { get; set; }

        public static MinIntParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MinIntParameter() { Pointer= p0 };

            value.Min                                       = GetInt32(new IntPtr(p + 0x020)); // 0246693589C8 0x20 Min                         ( 0001865F59B0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
