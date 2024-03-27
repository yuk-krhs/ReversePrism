using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Duration                                 000186666050 ModelPrimitiveType float float float Single
    // 014 PressPoint                               000186666050 ModelPrimitiveType float float float Single
    // 018 M_SlowTapStartTime                       0001865C2950 ModelPrimitiveType double double double Double
    public partial class SlowTapInteraction
    {
        public float                                    Duration                                { get; set; }
        public float                                    PressPoint                              { get; set; }
        public double                                   M_SlowTapStartTime                      { get; set; }

        public static SlowTapInteraction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SlowTapInteraction();

            value.Duration                                  = GetSingle(new IntPtr(p + 0x010)); // 0270D787ABB8 0x10 Duration                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.PressPoint                                = GetSingle(new IntPtr(p + 0x014)); // 0270D787ABD8 0x14 PressPoint                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_SlowTapStartTime                        = GetDouble(new IntPtr(p + 0x018)); // 0270D787ABF8 0x18 M_SlowTapStartTime          ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
