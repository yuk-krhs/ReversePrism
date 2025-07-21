using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayMask                              ModelPrimitiveType int int int Int32
    public partial class GUITargetAttribute : DataModel
    {
        public int                                      DisplayMask                             { get; set; }

        public static GUITargetAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUITargetAttribute() { Pointer= p0 };

            value.DisplayMask                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 DisplayMask                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
