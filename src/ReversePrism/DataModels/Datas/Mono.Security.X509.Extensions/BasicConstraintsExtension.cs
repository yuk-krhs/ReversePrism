using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 CA                                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C PathLenConstraint                        0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class BasicConstraintsExtension
    {
        public bool                                     CA                                      { get; set; }
        public int                                      PathLenConstraint                       { get; set; }

        public static BasicConstraintsExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BasicConstraintsExtension();

            value.CA                                        = GetBool(new IntPtr(p + 0x028)); // 0270DB37DF90 0x28 CA                          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PathLenConstraint                         = GetInt32(new IntPtr(p + 0x02C)); // 0270DB37DFB0 0x2C PathLenConstraint           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
