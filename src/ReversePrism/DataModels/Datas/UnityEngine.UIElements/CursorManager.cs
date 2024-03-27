using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsCursorOverriden                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CursorManager
    {
        public bool                                     IsCursorOverriden                       { get; set; }

        public static CursorManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CursorManager();

            value.IsCursorOverriden                         = GetBool(new IntPtr(p + 0x010)); // 027006750A38 0x10 IsCursorOverriden           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
