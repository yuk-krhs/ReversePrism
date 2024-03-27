using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 E_DBL                                    double IL2CPP_TYPE_R8
    // 000 LOG2E_DBL                                double IL2CPP_TYPE_R8
    // 000 LOG10E_DBL                               double IL2CPP_TYPE_R8
    // 000 LN2_DBL                                  double IL2CPP_TYPE_R8
    // 000 LN10_DBL                                 double IL2CPP_TYPE_R8
    // 000 PI_DBL                                   double IL2CPP_TYPE_R8
    // 000 SQRT2_DBL                                double IL2CPP_TYPE_R8
    // 000 EPSILON_DBL                              double IL2CPP_TYPE_R8
    // 000 INFINITY_DBL                             double IL2CPP_TYPE_R8
    // 000 NAN_DBL                                  double IL2CPP_TYPE_R8
    // 000 FLT_MIN_NORMAL                           float IL2CPP_TYPE_R4
    // 000 DBL_MIN_NORMAL                           double IL2CPP_TYPE_R8
    // 000 E                                        float IL2CPP_TYPE_R4
    // 000 LOG2E                                    float IL2CPP_TYPE_R4
    // 000 LOG10E                                   float IL2CPP_TYPE_R4
    // 000 LN2                                      float IL2CPP_TYPE_R4
    // 000 LN10                                     float IL2CPP_TYPE_R4
    // 000 PI                                       float IL2CPP_TYPE_R4
    // 000 SQRT2                                    float IL2CPP_TYPE_R4
    // 000 EPSILON                                  float IL2CPP_TYPE_R4
    // 000 INFINITY                                 float IL2CPP_TYPE_R4
    // 000 NAN                                      float IL2CPP_TYPE_R4
    public partial class math
    {

        public static math? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new math();


            return value;
        }
    }
}
