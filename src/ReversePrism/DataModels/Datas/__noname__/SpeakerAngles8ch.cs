using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FrontLeft                                ModelPrimitiveType float float float Single
    // 014 FrontRight                               ModelPrimitiveType float float float Single
    // 018 FrontCenter                              ModelPrimitiveType float float float Single
    // 01C LowFrequency                             ModelPrimitiveType float float float Single
    // 020 SurroundLeft                             ModelPrimitiveType float float float Single
    // 024 SurroundRight                            ModelPrimitiveType float float float Single
    // 028 SurroundBackLeft                         ModelPrimitiveType float float float Single
    // 02C SurroundBackRight                        ModelPrimitiveType float float float Single
    public partial class SpeakerAngles8ch : DataModel
    {
        public float                                    FrontLeft                               { get; set; }
        public float                                    FrontRight                              { get; set; }
        public float                                    FrontCenter                             { get; set; }
        public float                                    LowFrequency                            { get; set; }
        public float                                    SurroundLeft                            { get; set; }
        public float                                    SurroundRight                           { get; set; }
        public float                                    SurroundBackLeft                        { get; set; }
        public float                                    SurroundBackRight                       { get; set; }

        public static SpeakerAngles8ch? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpeakerAngles8ch() { Pointer= p0 };

            value.FrontLeft                                 = GetSingle(new IntPtr(p + 0x010)); // 0x10 FrontLeft                   ( ModelPrimitiveType float float float Single )
            value.FrontRight                                = GetSingle(new IntPtr(p + 0x014)); // 0x14 FrontRight                  ( ModelPrimitiveType float float float Single )
            value.FrontCenter                               = GetSingle(new IntPtr(p + 0x018)); // 0x18 FrontCenter                 ( ModelPrimitiveType float float float Single )
            value.LowFrequency                              = GetSingle(new IntPtr(p + 0x01C)); // 0x1C LowFrequency                ( ModelPrimitiveType float float float Single )
            value.SurroundLeft                              = GetSingle(new IntPtr(p + 0x020)); // 0x20 SurroundLeft                ( ModelPrimitiveType float float float Single )
            value.SurroundRight                             = GetSingle(new IntPtr(p + 0x024)); // 0x24 SurroundRight               ( ModelPrimitiveType float float float Single )
            value.SurroundBackLeft                          = GetSingle(new IntPtr(p + 0x028)); // 0x28 SurroundBackLeft            ( ModelPrimitiveType float float float Single )
            value.SurroundBackRight                         = GetSingle(new IntPtr(p + 0x02C)); // 0x2C SurroundBackRight           ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
