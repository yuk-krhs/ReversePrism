using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CanHaveAnyAttribute                      000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class BaseUxmlTraits : DataModel
    {
        public bool                                     CanHaveAnyAttribute                     { get; set; }

        public static BaseUxmlTraits? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseUxmlTraits() { Pointer= p0 };

            value.CanHaveAnyAttribute                       = GetBool(new IntPtr(p + 0x010)); // 0245A50E7508 0x10 CanHaveAnyAttribute         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
