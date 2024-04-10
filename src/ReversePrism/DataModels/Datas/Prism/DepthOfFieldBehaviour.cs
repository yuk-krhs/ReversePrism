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
    public partial class DepthOfFieldBehaviour : DataModel
    {
        public float                                    FocusDistance                           { get; set; }
        public float                                    Aperture                                { get; set; }
        public float                                    FocalLength                             { get; set; }

        public static DepthOfFieldBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DepthOfFieldBehaviour() { Pointer= p0 };

            value.FocusDistance                             = GetSingle(new IntPtr(p + 0x010)); // 024664E73940 0x10 FocusDistance               ( 000186666050 ModelPrimitiveType float float float Single )
            value.Aperture                                  = GetSingle(new IntPtr(p + 0x014)); // 024664E73960 0x14 Aperture                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.FocalLength                               = GetSingle(new IntPtr(p + 0x018)); // 024664E73980 0x18 FocalLength                 ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
