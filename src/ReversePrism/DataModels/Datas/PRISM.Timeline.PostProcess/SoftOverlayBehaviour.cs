using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 Weight                                   000186666050 ModelPrimitiveType float float float Single
    // 018 ScalingWeight                            000186666050 ModelPrimitiveType float float float Single
    // 01C Diffusion                                000186666050 ModelPrimitiveType float float float Single
    public partial class SoftOverlayBehaviour : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public float                                    Weight                                  { get; set; }
        public float                                    ScalingWeight                           { get; set; }
        public float                                    Diffusion                               { get; set; }

        public static SoftOverlayBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoftOverlayBehaviour() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0246650D9940 0x10 Enable                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Weight                                    = GetSingle(new IntPtr(p + 0x014)); // 0246650D9960 0x14 Weight                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.ScalingWeight                             = GetSingle(new IntPtr(p + 0x018)); // 0246650D9980 0x18 ScalingWeight               ( 000186666050 ModelPrimitiveType float float float Single )
            value.Diffusion                                 = GetSingle(new IntPtr(p + 0x01C)); // 0246650D99A0 0x1C Diffusion                   ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
