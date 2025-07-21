using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 WritableSelf                             ModelPrimitiveType bool bool bool Bool
    public partial class NativeWritableSelfAttribute : DataModel
    {
        public bool                                     WritableSelf                            { get; set; }

        public static NativeWritableSelfAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeWritableSelfAttribute() { Pointer= p0 };

            value.WritableSelf                              = GetBool(new IntPtr(p + 0x010)); // 0x10 WritableSelf                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
