using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Min                                      000186667B80 ModelPrimitiveType float float float Single
    public partial class NoInterpMinFloatParameter : DataModel
    {
        public float                                    Min                                     { get; set; }

        public static NoInterpMinFloatParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoInterpMinFloatParameter() { Pointer= p0 };

            value.Min                                       = GetSingle(new IntPtr(p + 0x020)); // 024669359658 0x20 Min                         ( 000186667B80 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
