using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_value                                  ModelPrimitiveType double double double Double
    // 000 MinValue                                 double IL2CPP_TYPE_R8
    // 000 MaxValue                                 double IL2CPP_TYPE_R8
    // 000 Epsilon                                  double IL2CPP_TYPE_R8
    // 000 NegativeInfinity                         double IL2CPP_TYPE_R8
    // 000 PositiveInfinity                         double IL2CPP_TYPE_R8
    // 000 NaN                                      double IL2CPP_TYPE_R8
    // 000 NegativeZero                             double IL2CPP_TYPE_R8
    public partial class Double : DataModel
    {
        public double                                   M_value                                 { get; set; }

        public static Double? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Double() { Pointer= p0 };

            value.M_value                                   = GetDouble(new IntPtr(p + 0x010)); // 0x10 M_value                     ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
