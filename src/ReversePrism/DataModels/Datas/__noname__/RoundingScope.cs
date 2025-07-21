using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OldBits                                  ModelEnumType MXCSRBits MXCSRBits MXCSRBits Int32
    public partial class RoundingScope : DataModel
    {
        public MXCSRBits                                OldBits                                 { get; set; }

        public static RoundingScope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RoundingScope() { Pointer= p0 };

            value.OldBits                                   = (MXCSRBits)GetInt32(new IntPtr(p + 0x010)); // 0x10 OldBits                     ( ModelEnumType MXCSRBits MXCSRBits MXCSRBits Int32 )

            return value;
        }
    }
}
