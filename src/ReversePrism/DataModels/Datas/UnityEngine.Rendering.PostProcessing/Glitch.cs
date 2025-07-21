using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 ScanLineJitter                           ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 038 VerticalJump                             ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 040 HorizontalShake                          ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 048 ColorDrift                               ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    public partial class Glitch : DataModel
    {
        public FloatParameter?                          ScanLineJitter                          { get; set; }
        public FloatParameter?                          VerticalJump                            { get; set; }
        public FloatParameter?                          HorizontalShake                         { get; set; }
        public FloatParameter?                          ColorDrift                              { get; set; }

        public static Glitch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Glitch() { Pointer= p0 };

            value.ScanLineJitter                            = GetObject<FloatParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x30 ScanLineJitter              ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.VerticalJump                              = GetObject<FloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x38 VerticalJump                ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.HorizontalShake                           = GetObject<FloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x40 HorizontalShake             ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.ColorDrift                                = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x48 ColorDrift                  ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )

            return value;
        }
    }
}
