using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   ModelPrimitiveType bool bool bool Bool
    // 014 ScanLineJitter                           ModelPrimitiveType float float float Single
    // 018 VerticalJump                             ModelPrimitiveType float float float Single
    // 01C HorizontalShake                          ModelPrimitiveType float float float Single
    // 020 ColorDrift                               ModelPrimitiveType float float float Single
    public partial class GlitchBehaviour : DataModel
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
            var value   = new GlitchBehaviour() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 Enable                      ( ModelPrimitiveType bool bool bool Bool )
            value.ScanLineJitter                            = GetSingle(new IntPtr(p + 0x014)); // 0x14 ScanLineJitter              ( ModelPrimitiveType float float float Single )
            value.VerticalJump                              = GetSingle(new IntPtr(p + 0x018)); // 0x18 VerticalJump                ( ModelPrimitiveType float float float Single )
            value.HorizontalShake                           = GetSingle(new IntPtr(p + 0x01C)); // 0x1C HorizontalShake             ( ModelPrimitiveType float float float Single )
            value.ColorDrift                                = GetSingle(new IntPtr(p + 0x020)); // 0x20 ColorDrift                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
