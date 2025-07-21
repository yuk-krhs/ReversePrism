using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 IsAnimatorMotion                         ModelPrimitiveType bool bool bool Bool
    public partial class Motion : DataModel
    {
        public bool                                     IsAnimatorMotion                        { get; set; }

        public static Motion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Motion() { Pointer= p0 };

            value.IsAnimatorMotion                          = GetBool(new IntPtr(p + 0x018)); // 0x18 IsAnimatorMotion            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
