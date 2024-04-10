using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_X                                      0001866061D0 ModelEnumType Length Length Length Int32
    // 018 M_Y                                      0001866061D0 ModelEnumType Length Length Length Int32
    // 020 M_Z                                      0001866656B0 ModelPrimitiveType float float float Single
    public partial class TransformOrigin : DataModel
    {
        public Length                                   M_X                                     { get; set; }
        public Length                                   M_Y                                     { get; set; }
        public float                                    M_Z                                     { get; set; }

        public static TransformOrigin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformOrigin() { Pointer= p0 };

            value.M_X                                       = (Length)GetInt32(new IntPtr(p + 0x010)); // 0245A3F20BE0 0x10 M_X                         ( 0001866061D0 ModelEnumType Length Length Length Int32 )
            value.M_Y                                       = (Length)GetInt32(new IntPtr(p + 0x018)); // 0245A3F20C00 0x18 M_Y                         ( 0001866061D0 ModelEnumType Length Length Length Int32 )
            value.M_Z                                       = GetSingle(new IntPtr(p + 0x020)); // 0245A3F20C20 0x20 M_Z                         ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
