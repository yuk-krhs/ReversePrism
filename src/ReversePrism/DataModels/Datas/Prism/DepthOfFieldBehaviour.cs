using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FocusDistance                            000186666050 ModelPrimitiveType float float float Single
    // 014 Aperture                                 000186666050 ModelPrimitiveType float float float Single
    // 018 FocalLength                              000186666050 ModelPrimitiveType float float float Single
    public partial class DepthOfFieldBehaviour
    {
        public float                                    FocusDistance                           { get; set; }
        public float                                    Aperture                                { get; set; }
        public float                                    FocalLength                             { get; set; }

        public static DepthOfFieldBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DepthOfFieldBehaviour();

            value.FocusDistance                             = GetSingle(new IntPtr(p + 0x010)); // 027006B64EB8 0x10 FocusDistance               ( 000186666050 ModelPrimitiveType float float float Single )
            value.Aperture                                  = GetSingle(new IntPtr(p + 0x014)); // 027006B64ED8 0x14 Aperture                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.FocalLength                               = GetSingle(new IntPtr(p + 0x018)); // 027006B64EF8 0x18 FocalLength                 ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
