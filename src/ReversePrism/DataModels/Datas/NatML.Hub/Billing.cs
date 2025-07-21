using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Plan                                     ModelPrimitiveType string string string String
    public partial class Billing : DataModel
    {
        public string                                   Plan                                    { get; set; }

        public static Billing? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Billing() { Pointer= p0 };

            value.Plan                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Plan                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
