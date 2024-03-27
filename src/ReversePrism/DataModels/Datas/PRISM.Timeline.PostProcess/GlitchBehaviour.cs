using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 ScanLineJitter                           000186666050 ModelPrimitiveType float float float Single
    // 018 VerticalJump                             000186666050 ModelPrimitiveType float float float Single
    // 01C HorizontalShake                          000186666050 ModelPrimitiveType float float float Single
    // 020 ColorDrift                               000186666050 ModelPrimitiveType float float float Single
    public partial class GlitchBehaviour
    {
        public bool                                     Enable                                  { get; set; }
        public float                                    ScanLineJitter                          { get; set; }
        public float                                    VerticalJump                            { get; set; }
        public float                                    HorizontalShake                         { get; set; }
        public float                                    ColorDrift                              { get; set; }

        public static GlitchBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlitchBehaviour();

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0270D50751F8 0x10 Enable                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ScanLineJitter                            = GetSingle(new IntPtr(p + 0x014)); // 0270D5075218 0x14 ScanLineJitter              ( 000186666050 ModelPrimitiveType float float float Single )
            value.VerticalJump                              = GetSingle(new IntPtr(p + 0x018)); // 0270D5075238 0x18 VerticalJump                ( 000186666050 ModelPrimitiveType float float float Single )
            value.HorizontalShake                           = GetSingle(new IntPtr(p + 0x01C)); // 0270D5075258 0x1C HorizontalShake             ( 000186666050 ModelPrimitiveType float float float Single )
            value.ColorDrift                                = GetSingle(new IntPtr(p + 0x020)); // 0270D5075278 0x20 ColorDrift                  ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
