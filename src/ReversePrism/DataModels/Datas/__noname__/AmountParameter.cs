using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Amount                                   ModelPrimitiveType double double double Double
    public partial class AmountParameter : DataModel
    {
        public double                                   Amount                                  { get; set; }

        public static AmountParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AmountParameter() { Pointer= p0 };

            value.Amount                                    = GetDouble(new IntPtr(p + 0x010)); // 0x10 Amount                      ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
