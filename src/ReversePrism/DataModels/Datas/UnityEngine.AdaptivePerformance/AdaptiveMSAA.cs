using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_DefaultAA                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AdaptiveMSAA
    {
        public int                                      M_DefaultAA                             { get; set; }

        public static AdaptiveMSAA? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptiveMSAA();

            value.M_DefaultAA                               = GetInt32(new IntPtr(p + 0x040)); // 0270DB689AF8 0x40 M_DefaultAA                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
