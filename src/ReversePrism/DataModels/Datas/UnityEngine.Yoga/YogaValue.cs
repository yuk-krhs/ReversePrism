using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    0001866656B0 ModelPrimitiveType float float float Single
    // 014 Unit                                     0001865DEF50 ModelEnumType YogaUnit YogaUnit YogaUnit Int32
    public partial class YogaValue
    {
        public float                                    Value                                   { get; set; }
        public YogaUnit                                 Unit                                    { get; set; }

        public static YogaValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new YogaValue();

            value.Value                                     = GetSingle(new IntPtr(p + 0x010)); // 0270066DEA28 0x10 Value                       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Unit                                      = (YogaUnit)GetInt32(new IntPtr(p + 0x014)); // 0270066DEA48 0x14 Unit                        ( 0001865DEF50 ModelEnumType YogaUnit YogaUnit YogaUnit Int32 )

            return value;
        }
    }
}
