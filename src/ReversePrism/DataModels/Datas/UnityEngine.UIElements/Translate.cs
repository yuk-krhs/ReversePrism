using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_X                                      ModelEnumType Length Length Length Int32
    // 018 M_Y                                      ModelEnumType Length Length Length Int32
    // 020 M_Z                                      ModelPrimitiveType float float float Single
    // 024 M_isNone                                 ModelPrimitiveType bool bool bool Bool
    public partial class Translate : DataModel
    {
        public Length                                   M_X                                     { get; set; }
        public Length                                   M_Y                                     { get; set; }
        public float                                    M_Z                                     { get; set; }
        public bool                                     M_isNone                                { get; set; }

        public static Translate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Translate() { Pointer= p0 };

            value.M_X                                       = (Length)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_X                         ( ModelEnumType Length Length Length Int32 )
            value.M_Y                                       = (Length)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Y                         ( ModelEnumType Length Length Length Int32 )
            value.M_Z                                       = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_Z                         ( ModelPrimitiveType float float float Single )
            value.M_isNone                                  = GetBool(new IntPtr(p + 0x024)); // 0x24 M_isNone                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
