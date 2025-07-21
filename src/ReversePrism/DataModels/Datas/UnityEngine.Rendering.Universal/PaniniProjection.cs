using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Distance                                 ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 040 CropToFit                                ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    public partial class PaniniProjection : DataModel
    {
        public ClampedFloatParameter?                   Distance                                { get; set; }
        public ClampedFloatParameter?                   CropToFit                               { get; set; }

        public static PaniniProjection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PaniniProjection() { Pointer= p0 };

            value.Distance                                  = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x38 Distance                    ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.CropToFit                                 = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x40 CropToFit                   ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )

            return value;
        }
    }
}
