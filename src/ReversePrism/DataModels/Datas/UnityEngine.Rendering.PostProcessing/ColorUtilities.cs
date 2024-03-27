using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 logC_cut                                 float IL2CPP_TYPE_R4
    // 000 logC_a                                   float IL2CPP_TYPE_R4
    // 000 logC_b                                   float IL2CPP_TYPE_R4
    // 000 logC_c                                   float IL2CPP_TYPE_R4
    // 000 logC_d                                   float IL2CPP_TYPE_R4
    // 000 logC_e                                   float IL2CPP_TYPE_R4
    // 000 logC_f                                   float IL2CPP_TYPE_R4
    public partial class ColorUtilities
    {

        public static ColorUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorUtilities();


            return value;
        }
    }
}
