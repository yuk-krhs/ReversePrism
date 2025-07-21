using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Code                                   ModelPrimitiveType int int int Int32
    public partial class FourCC : DataModel
    {
        public int                                      M_Code                                  { get; set; }

        public static FourCC? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FourCC() { Pointer= p0 };

            value.M_Code                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Code                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
