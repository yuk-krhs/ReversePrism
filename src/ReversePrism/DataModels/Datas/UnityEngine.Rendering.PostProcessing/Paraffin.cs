using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Color                                    ModelClassType ColorParameter ColorParameter ColorParameter Pointer
    // 038 Rotate                                   ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 040 Edge0                                    ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    // 048 Edge1                                    ModelClassType FloatParameter FloatParameter FloatParameter Pointer
    public partial class Paraffin : DataModel
    {
        public ColorParameter?                          Color                                   { get; set; }
        public FloatParameter?                          Rotate                                  { get; set; }
        public FloatParameter?                          Edge0                                   { get; set; }
        public FloatParameter?                          Edge1                                   { get; set; }

        public static Paraffin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Paraffin() { Pointer= p0 };

            value.Color                                     = GetObject<ColorParameter>(new IntPtr(p + 0x030), ReversePrism.DataModels.ColorParameter.FromPointer); // 0x30 Color                       ( ModelClassType ColorParameter ColorParameter ColorParameter Pointer )
            value.Rotate                                    = GetObject<FloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x38 Rotate                      ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Edge0                                     = GetObject<FloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x40 Edge0                       ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )
            value.Edge1                                     = GetObject<FloatParameter>(new IntPtr(p + 0x048), ReversePrism.DataModels.FloatParameter.FromPointer); // 0x48 Edge1                       ( ModelClassType FloatParameter FloatParameter FloatParameter Pointer )

            return value;
        }
    }
}
