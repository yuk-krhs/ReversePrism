using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 CA                                       ModelPrimitiveType bool bool bool Bool
    // 02C PathLenConstraint                        ModelPrimitiveType int int int Int32
    public partial class BasicConstraintsExtension : DataModel
    {
        public bool                                     CA                                      { get; set; }
        public int                                      PathLenConstraint                       { get; set; }

        public static BasicConstraintsExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BasicConstraintsExtension() { Pointer= p0 };

            value.CA                                        = GetBool(new IntPtr(p + 0x028)); // 0x28 CA                          ( ModelPrimitiveType bool bool bool Bool )
            value.PathLenConstraint                         = GetInt32(new IntPtr(p + 0x02C)); // 0x2C PathLenConstraint           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
