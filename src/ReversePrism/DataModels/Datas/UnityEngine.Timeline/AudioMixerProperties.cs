using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Volume                                   000186666050 ModelPrimitiveType float float float Single
    // 014 StereoPan                                000186666050 ModelPrimitiveType float float float Single
    // 018 SpatialBlend                             000186666050 ModelPrimitiveType float float float Single
    public partial class AudioMixerProperties : DataModel
    {
        public float                                    Volume                                  { get; set; }
        public float                                    StereoPan                               { get; set; }
        public float                                    SpatialBlend                            { get; set; }

        public static AudioMixerProperties? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AudioMixerProperties() { Pointer= p0 };

            value.Volume                                    = GetSingle(new IntPtr(p + 0x010)); // 02466B2CB200 0x10 Volume                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.StereoPan                                 = GetSingle(new IntPtr(p + 0x014)); // 02466B2CB220 0x14 StereoPan                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.SpatialBlend                              = GetSingle(new IntPtr(p + 0x018)); // 02466B2CB240 0x18 SpatialBlend                ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
