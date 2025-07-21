using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NumDsp                                   ModelPrimitiveType int int int Int32
    // 014 MaxChannels                              ModelPrimitiveType int int int Int32
    // 018 MaxSamplingRate                          ModelPrimitiveType int int int Int32
    // 01C Config                                   ModelEnumType PitchShifterConfig PitchShifterConfig PitchShifterConfig Int32
    public partial class ExPitchShifterConfig : DataModel
    {
        public int                                      NumDsp                                  { get; set; }
        public int                                      MaxChannels                             { get; set; }
        public int                                      MaxSamplingRate                         { get; set; }
        public PitchShifterConfig                       Config                                  { get; set; }

        public static ExPitchShifterConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExPitchShifterConfig() { Pointer= p0 };

            value.NumDsp                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 NumDsp                      ( ModelPrimitiveType int int int Int32 )
            value.MaxChannels                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 MaxChannels                 ( ModelPrimitiveType int int int Int32 )
            value.MaxSamplingRate                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 MaxSamplingRate             ( ModelPrimitiveType int int int Int32 )
            value.Config                                    = (PitchShifterConfig)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Config                      ( ModelEnumType PitchShifterConfig PitchShifterConfig PitchShifterConfig Int32 )

            return value;
        }
    }
}
