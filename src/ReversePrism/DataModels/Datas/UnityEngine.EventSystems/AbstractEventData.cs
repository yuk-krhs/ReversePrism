using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Used                                   000186595480 ModelPrimitiveType bool bool bool Bool
    public partial class AbstractEventData
    {
        public bool                                     M_Used                                  { get; set; }

        public static AbstractEventData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AbstractEventData();

            value.M_Used                                    = GetBool(new IntPtr(p + 0x010)); // 027003EBC918 0x10 M_Used                      ( 000186595480 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
