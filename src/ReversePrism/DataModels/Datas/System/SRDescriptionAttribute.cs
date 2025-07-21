using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 IsReplaced                               ModelPrimitiveType bool bool bool Bool
    public partial class SRDescriptionAttribute : DataModel
    {
        public bool                                     IsReplaced                              { get; set; }

        public static SRDescriptionAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SRDescriptionAttribute() { Pointer= p0 };

            value.IsReplaced                                = GetBool(new IntPtr(p + 0x018)); // 0x18 IsReplaced                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
