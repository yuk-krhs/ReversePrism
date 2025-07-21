using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsCursorOverriden                        ModelPrimitiveType bool bool bool Bool
    public partial class CursorManager : DataModel
    {
        public bool                                     IsCursorOverriden                       { get; set; }

        public static CursorManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CursorManager() { Pointer= p0 };

            value.IsCursorOverriden                         = GetBool(new IntPtr(p + 0x010)); // 0x10 IsCursorOverriden           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
