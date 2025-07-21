using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Shadows                                  ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 040 Highlights                               ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 048 Balance                                  ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    public partial class SplitToning : DataModel
    {
        public ColorParameter?                          Shadows                                 { get; set; }
        public ColorParameter?                          Highlights                              { get; set; }
        public ClampedFloatParameter?                   Balance                                 { get; set; }

        public static SplitToning? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SplitToning() { Pointer= p0 };

            value.Shadows                                   = GetObject<ColorParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ColorParameter.FromPointer); // 0x38 Shadows                     ( ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.Highlights                                = GetObject<ColorParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.ColorParameter.FromPointer); // 0x40 Highlights                  ( ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.Balance                                   = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x48 Balance                     ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )

            return value;
        }
    }
}
