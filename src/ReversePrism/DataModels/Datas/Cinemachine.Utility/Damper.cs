using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Epsilon                                  float IL2CPP_TYPE_R4
    // 000 kNegligibleResidual                      float IL2CPP_TYPE_R4
    // 000 kLogNegligibleResidual                   float IL2CPP_TYPE_R4
    public partial class Damper : DataModel
    {

        public static Damper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Damper() { Pointer= p0 };


            return value;
        }
    }
}
