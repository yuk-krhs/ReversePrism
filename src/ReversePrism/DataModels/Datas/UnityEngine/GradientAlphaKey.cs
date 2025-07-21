using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Alpha                                    ModelPrimitiveType float float float Single
    // 014 Time                                     ModelPrimitiveType float float float Single
    public partial class GradientAlphaKey : DataModel
    {
        public float                                    Alpha                                   { get; set; }
        public float                                    Time                                    { get; set; }

        public static GradientAlphaKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GradientAlphaKey() { Pointer= p0 };

            value.Alpha                                     = GetSingle(new IntPtr(p + 0x010)); // 0x10 Alpha                       ( ModelPrimitiveType float float float Single )
            value.Time                                      = GetSingle(new IntPtr(p + 0x014)); // 0x14 Time                        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
