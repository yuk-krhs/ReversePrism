using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ModelPrimitiveType float float float Single
    // 014 Use                                      ModelPrimitiveType bool bool bool Bool
    public partial class CheckSliderSerializeData : DataModel
    {
        public float                                    Value                                   { get; set; }
        public bool                                     Use                                     { get; set; }

        public static CheckSliderSerializeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CheckSliderSerializeData() { Pointer= p0 };

            value.Value                                     = GetSingle(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelPrimitiveType float float float Single )
            value.Use                                       = GetBool(new IntPtr(p + 0x014)); // 0x14 Use                         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
