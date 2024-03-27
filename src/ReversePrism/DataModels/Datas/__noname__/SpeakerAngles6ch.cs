using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FrontLeft                                000186666050 ModelPrimitiveType float float float Single
    // 014 FrontRight                               000186666050 ModelPrimitiveType float float float Single
    // 018 FrontCenter                              000186666050 ModelPrimitiveType float float float Single
    // 01C LowFrequency                             000186666050 ModelPrimitiveType float float float Single
    // 020 SurroundLeft                             000186666050 ModelPrimitiveType float float float Single
    // 024 SurroundRight                            000186666050 ModelPrimitiveType float float float Single
    public partial class SpeakerAngles6ch
    {
        public float                                    FrontLeft                               { get; set; }
        public float                                    FrontRight                              { get; set; }
        public float                                    FrontCenter                             { get; set; }
        public float                                    LowFrequency                            { get; set; }
        public float                                    SurroundLeft                            { get; set; }
        public float                                    SurroundRight                           { get; set; }

        public static SpeakerAngles6ch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpeakerAngles6ch();

            value.FrontLeft                                 = GetSingle(new IntPtr(p + 0x010)); // 0270DAC6C1C0 0x10 FrontLeft                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.FrontRight                                = GetSingle(new IntPtr(p + 0x014)); // 0270DAC6C1E0 0x14 FrontRight                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.FrontCenter                               = GetSingle(new IntPtr(p + 0x018)); // 0270DAC6C200 0x18 FrontCenter                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.LowFrequency                              = GetSingle(new IntPtr(p + 0x01C)); // 0270DAC6C220 0x1C LowFrequency                ( 000186666050 ModelPrimitiveType float float float Single )
            value.SurroundLeft                              = GetSingle(new IntPtr(p + 0x020)); // 0270DAC6C240 0x20 SurroundLeft                ( 000186666050 ModelPrimitiveType float float float Single )
            value.SurroundRight                             = GetSingle(new IntPtr(p + 0x024)); // 0270DAC6C260 0x24 SurroundRight               ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
