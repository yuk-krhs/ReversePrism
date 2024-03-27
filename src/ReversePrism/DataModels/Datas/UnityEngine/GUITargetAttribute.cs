using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayMask                              0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class GUITargetAttribute
    {
        public int                                      DisplayMask                             { get; set; }

        public static GUITargetAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUITargetAttribute();

            value.DisplayMask                               = GetInt32(new IntPtr(p + 0x010)); // 0270021DCD30 0x10 DisplayMask                 ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
