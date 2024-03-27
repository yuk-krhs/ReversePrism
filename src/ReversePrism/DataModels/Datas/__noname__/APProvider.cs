using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Running                                000186595480 ModelPrimitiveType bool bool bool Bool
    public partial class APProvider
    {
        public bool                                     M_Running                               { get; set; }

        public static APProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new APProvider();

            value.M_Running                                 = GetBool(new IntPtr(p + 0x018)); // 0270001A2DC8 0x18 M_Running                   ( 000186595480 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
