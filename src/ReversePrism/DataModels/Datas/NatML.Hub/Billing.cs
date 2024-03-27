using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Plan                                     0001866722E0 ModelPrimitiveType string string string String
    public partial class Billing
    {
        public string                                   Plan                                    { get; set; }

        public static Billing? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Billing();

            value.Plan                                      = GetString(new IntPtr(p + 0x010)); // 027003342368 0x10 Plan                        ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
